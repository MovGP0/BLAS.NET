using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Perform the operation of copying a single-precision matrix with possible transposition.
    /// </summary>
    /// <param name="trans">The transpose operation flag.</param>
    /// <param name="order">The matrix order flag.</param>
    /// <param name="alpha">The single-precision scalar alpha.</param>
    /// <param name="a">The source single-precision matrix A.</param>
    /// <param name="b">The destination single-precision matrix B.</param>
    public static void OrderedMatrixCopy(Transpose trans, Order order, float alpha, float[,] a, float[,] b)
    {
        if (a.Length == 0 || b.Length == 0)
        {
            throw new ArgumentException("Matrices cannot be empty.");
        }

        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows <= 0 || cols <= 0)
        {
            throw new ArgumentException("Number of rows and columns must be positive non-zero integers.");
        }

        if (rows != b.GetLength(0) || cols != b.GetLength(1))
        {
            throw new ArgumentException("Source and destination matrices must have the same dimensions.");
        }

        unsafe
        {
            fixed (float* pA = a, pB = b)
            {
                sbyte transByte = (sbyte)trans;
                sbyte orderByte = (sbyte)order;
                OpenBlas.Somatcopy(&transByte, &orderByte, &rows, &cols, &alpha, pA, &rows, pB, &rows);
            }
        }
    }

    /// <summary>
    /// Perform the operation of copying a double-precision matrix with possible transposition.
    /// </summary>
    /// <param name="trans">The transpose operation flag.</param>
    /// <param name="order">The matrix order flag.</param>
    /// <param name="alpha">The double-precision scalar alpha.</param>
    /// <param name="a">The source double-precision matrix A.</param>
    /// <param name="b">The destination double-precision matrix B.</param>
    public static void OrderedMatrixCopy(Transpose trans, Order order, double alpha, double[,] a, double[,] b)
    {
        if (a.Length == 0 || b.Length == 0)
        {
            throw new ArgumentException("Matrices cannot be empty.");
        }

        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows <= 0 || cols <= 0)
        {
            throw new ArgumentException("Number of rows and columns must be positive non-zero integers.");
        }

        if (rows != b.GetLength(0) || cols != b.GetLength(1))
        {
            throw new ArgumentException("Source and destination matrices must have the same dimensions.");
        }

        unsafe
        {
            fixed (double* pA = a, pB = b)
            {
                sbyte transByte = (sbyte)trans;
                sbyte orderByte = (sbyte)order;
                OpenBlas.Domatcopy(&transByte, &orderByte, &rows, &cols, &alpha, pA, &rows, pB, &rows);
            }
        }
    }

    /// <summary>
    /// Perform the operation of copying a single-precision complex matrix with possible transposition.
    /// </summary>
    /// <param name="trans">The transpose operation flag.</param>
    /// <param name="order">The matrix order flag.</param>
    /// <param name="alpha">The single-precision scalar alpha.</param>
    /// <param name="a">The source single-precision complex matrix A.</param>
    /// <param name="b">The destination single-precision complex matrix B.</param>
    public static void OrderedMatrixCopy(Transpose trans, Order order, ComplexFloat alpha, ComplexFloat[,] a, ComplexFloat[,] b)
    {
        if (a.Length == 0 || b.Length == 0)
        {
            throw new ArgumentException("Matrices cannot be empty.");
        }

        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows <= 0 || cols <= 0)
        {
            throw new ArgumentException("Number of rows and columns must be positive non-zero integers.");
        }

        if (rows != b.GetLength(0) || cols != b.GetLength(1))
        {
            throw new ArgumentException("Source and destination matrices must have the same dimensions.");
        }

        unsafe
        {
            fixed (ComplexFloat* pA = a, pB = b)
            {
                sbyte transByte = (sbyte)trans;
                sbyte orderByte = (sbyte)order;
                OpenBlas.Comatcopy(&transByte, &orderByte, &rows, &cols, &alpha, pA, &rows, pB, &rows);
            }
        }
    }

    /// <summary>
    /// Perform the operation of copying a double-precision complex matrix with possible transposition.
    /// </summary>
    /// <param name="trans">The transpose operation flag.</param>
    /// <param name="order">The matrix order flag.</param>
    /// <param name="alpha">The double-precision scalar alpha.</param>
    /// <param name="a">The source double-precision complex matrix A.</param>
    /// <param name="b">The destination double-precision complex matrix B.</param>
    public static void OrderedMatrixCopy(Transpose trans, Order order, ComplexDouble alpha, ComplexDouble[,] a, ComplexDouble[,] b)
    {
        if (a.Length == 0 || b.Length == 0)
        {
            throw new ArgumentException("Matrices cannot be empty.");
        }

        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows <= 0 || cols <= 0)
        {
            throw new ArgumentException("Number of rows and columns must be positive non-zero integers.");
        }

        if (rows != b.GetLength(0) || cols != b.GetLength(1))
        {
            throw new ArgumentException("Source and destination matrices must have the same dimensions.");
        }

        unsafe
        {
            fixed (ComplexDouble* pA = a, pB = b)
            {
                sbyte transByte = (sbyte)trans;
                sbyte orderByte = (sbyte)order;
                OpenBlas.Zomatcopy(&transByte, &orderByte, &rows, &cols, &alpha, pA, &rows, pB, &rows);
            }
        }
    }
}