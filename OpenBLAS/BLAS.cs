using System.Diagnostics.Contracts;
using System.Text;
using OpenBLAS.PInvoke;

namespace OpenBLAS;

/// <summary>
/// Basic Linear Algebra Subprograms (BLAS) wrapper based on OpenBLAS
/// </summary>
/// <remarks>
/// See <a href="https://de.wikipedia.org/wiki/Basic_Linear_Algebra_Subprograms">Wikipedia: Basic Linear Algebra Subprograms</a>
/// </remarks>
public static partial class BLAS
{
    /// <summary>
    /// The Xerbla method is an error handler used in LAPACK (Linear Algebra PACKage) routines.
    /// It typically returns an integer value that indicates the nature of the error encountered.
    /// </summary>
    /// <param name="routineName">The name of the routine which called XERBLA.</param>
    /// <param name="info">Pointer to the error code (info).</param>
    /// <returns>An integer indicating the status of the operation.
    /// <c>-1</c> to <c>-n</c>: Indicates which parameter of the LAPACK routine is erroneous (where n is the parameter position).
    /// <c>0</c>: Indicates no error detected (uncommon for Xerbla as it is designed to report errors).
    /// </returns>
    public static int Xerbla(string routineName, int info)
    {
        // Convert the routineName to a null-terminated sbyte array
        byte[] routineNameBytes = Encoding.ASCII.GetBytes(routineName);
        sbyte[] srname = Array.ConvertAll(routineNameBytes, b => unchecked((sbyte)b));

        // Allocate memory for srname pointer and copy data
        IntPtr srnamePtr = Marshal.AllocHGlobal(srname.Length + 1);
        Marshal.Copy(routineNameBytes, 0, srnamePtr, routineNameBytes.Length);
        Marshal.WriteByte(srnamePtr + routineNameBytes.Length, 0); // Null-terminate the string

        IntPtr infoPtr = Marshal.AllocHGlobal(sizeof(int));
        Marshal.WriteInt32(infoPtr, info);

        try
        {
            return OpenBlas.Xerbla(srnamePtr, infoPtr, srname.Length);
        }
        finally
        {
            // Free the allocated memory
            Marshal.FreeHGlobal(srnamePtr);
            Marshal.FreeHGlobal(infoPtr);
        }
    }

    public static int NumThreads
    {
        set => OpenBlas.SetNumThreads(value);
        get => OpenBlas.GetNumThreads();
    }

    public static int GotoNumThreads
    {
        set => OpenBlas.GotoSetNumThreads(value);
    }

    public static int NumProcs => OpenBlas.GetNumProcs();
    public static int Parallel => OpenBlas.GetParallel();

    /// <summary>
    /// Gets the configuration information of the OpenBLAS library.
    /// </summary>
    /// <returns>A string containing the configuration information.</returns>
    public static string Config
    {
        get
        {
            IntPtr configPtr = OpenBlas.GetConfig();
            return PtrToStringUtf8(configPtr);
        }
    }

    /// <summary>
    /// Gets the core name used by the OpenBLAS library.
    /// </summary>
    /// <returns>A string containing the core name.</returns>
    public static string Corename
    {
        get
        {
            IntPtr coreNamePtr = OpenBlas.GetCoreName();
            return PtrToStringUtf8(coreNamePtr);
        }
    }

    /// <summary>
    /// Converts an IntPtr pointing to a UTF-8 encoded null-terminated string to a managed string.
    /// </summary>
    /// <param name="ptr">Pointer to the UTF-8 encoded null-terminated string.</param>
    /// <returns>The managed string.</returns>
    [Pure]
    private static string PtrToStringUtf8(IntPtr ptr)
    {
        if (ptr == IntPtr.Zero)
            return null;

        // Find the length of the string by looking for the null terminator
        int len = 0;
        while (Marshal.ReadByte(ptr, len) != 0)
        {
            len++;
        }

        // Create a byte array to hold the string
        byte[] bytes = new byte[len];
        Marshal.Copy(ptr, bytes, 0, len);

        // Convert the byte array to a string
        return Encoding.UTF8.GetString(bytes);
    }
}