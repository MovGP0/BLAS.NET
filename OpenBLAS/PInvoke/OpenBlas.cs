using System.Security;

namespace OpenBLAS.PInvoke;

/// <summary>
/// Wrapper class for P/Invoke calls to the OpenBLAS library.
/// </summary>
[SuppressUnmanagedCodeSecurity]
internal static partial class OpenBlas
{
    /// <summary>
    /// Error handler for LAPACK routines.
    /// </summary>
    /// <param name="srname">Pointer to the name of the routine which called XERBLA.</param>
    /// <param name="info">Pointer to the error code (info).</param>
    /// <param name="srname_len">Length of the routine name string.</param>
    /// <returns>An integer indicating the status of the operation.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "xerbla")]
    internal static extern int Xerbla(IntPtr srname, IntPtr info, int srname_len);

    /// <summary>
    /// Sets the number of threads to be used by OpenBLAS.
    /// </summary>
    /// <param name="numThreads">The number of threads to be used.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_set_num_threads")]
    internal static extern void SetNumThreads(int numThreads);

    /// <summary>
    /// Gets the number of threads currently used by OpenBLAS.
    /// </summary>
    /// <returns>The number of threads currently used by OpenBLAS.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_get_num_threads")]
    internal static extern int GetNumThreads();

    /// <summary>
    /// Sets the number of threads to be used by GotoBLAS.
    /// </summary>
    /// <param name="numThreads">The number of threads to be used.</param>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "goto_set_num_threads")]
    internal static extern void GotoSetNumThreads(int numThreads);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint="openblas_get_num_procs")]
    internal static extern int GetNumProcs();

    /// <summary>
    /// Checks if OpenBLAS is using parallel execution.
    /// </summary>
    /// <returns>A boolean indicating whether parallel execution is enabled.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_get_parallel")]
    internal static extern int GetParallel();

    /// <summary>
    /// Gets the configuration information of the OpenBLAS library.
    /// </summary>
    /// <returns>A pointer to a null-terminated string containing the configuration information.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_get_config")]
    internal static extern IntPtr GetConfig();

    /// <summary>
    /// Gets the core name used by the OpenBLAS library.
    /// </summary>
    /// <returns>A pointer to a null-terminated string containing the core name.</returns>
    [DllImport("libopenblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "openblas_get_corename")]
    internal static extern IntPtr GetCoreName();
}
