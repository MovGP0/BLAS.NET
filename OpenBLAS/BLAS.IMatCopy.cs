using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Perform the operation of copying a single-precision matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">The transpose operation flag.</param>
    /// <param name="order">The matrix order flag.</param>
    /// <param name="alpha">The single-precision scalar alpha.</param>
    /// <param name="a">The source and destination single-precision matrix A.</param>
    public static void InPlaceMatrixCopy(Transpose trans, Order order, float alpha, float[,] a)
    {
        if (a.Length == 0)
        {
            throw new ArgumentException("Matrix cannot be empty.");
        }

        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows <= 0 || cols <= 0)
        {
            throw new ArgumentException("Number of rows and columns must be positive non-zero integers.");
        }

        unsafe
        {
            fixed (float* pA = a)
            {
                sbyte transByte = (sbyte)trans;
                sbyte orderByte = (sbyte)order;
                OpenBlas.Simatcopy(&transByte, &orderByte, &rows, &cols, &alpha, pA, &rows, &cols);
            }
        }
    }

    /// <summary>
    /// Perform the operation of copying a double-precision matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">The transpose operation flag.</param>
    /// <param name="order">The matrix order flag.</param>
    /// <param name="alpha">The double-precision scalar alpha.</param>
    /// <param name="a">The source and destination double-precision matrix A.</param>
    public static void InPlaceMatrixCopy(Transpose trans, Order order, double alpha, double[,] a)
    {
        if (a.Length == 0)
        {
            throw new ArgumentException("Matrix cannot be empty.");
        }

        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows <= 0 || cols <= 0)
        {
            throw new ArgumentException("Number of rows and columns must be positive non-zero integers.");
        }

        unsafe
        {
            fixed (double* pA = a)
            {
                sbyte transByte = (sbyte)trans;
                sbyte orderByte = (sbyte)order;
                OpenBlas.Dimatcopy(&transByte, &orderByte, &rows, &cols, &alpha, pA, &rows, &cols);
            }
        }
    }

    /// <summary>
    /// Perform the operation of copying a single-precision complex matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">The transpose operation flag.</param>
    /// <param name="order">The matrix order flag.</param>
    /// <param name="alpha">The single-precision scalar alpha.</param>
    /// <param name="a">The source and destination single-precision complex matrix A.</param>
    public static void InPlaceMatrixCopy(Transpose trans, Order order, ComplexFloat alpha, ComplexFloat[,] a)
    {
        if (a.Length == 0)
        {
            throw new ArgumentException("Matrix cannot be empty.");
        }

        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows <= 0 || cols <= 0)
        {
            throw new ArgumentException("Number of rows and columns must be positive non-zero integers.");
        }

        unsafe
        {
            fixed (ComplexFloat* pA = a)
            {
                sbyte transByte = (sbyte)trans;
                sbyte orderByte = (sbyte)order;
                OpenBlas.Cimatcopy(&transByte, &orderByte, &rows, &cols, &alpha, pA, &rows, &cols);
            }
        }
    }

    /// <summary>
    /// Perform the operation of copying a double-precision complex matrix with possible in-place transposition.
    /// </summary>
    /// <param name="trans">The transpose operation flag.</param>
    /// <param name="order">The matrix order flag.</param>
    /// <param name="alpha">The double-precision scalar alpha.</param>
    /// <param name="a">The source and destination double-precision complex matrix A.</param>
    public static void InPlaceMatrixCopy(Transpose trans, Order order, ComplexDouble alpha, ComplexDouble[,] a)
    {
        if (a.Length == 0)
        {
            throw new ArgumentException("Matrix cannot be empty.");
        }

        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        if (rows <= 0 || cols <= 0)
        {
            throw new ArgumentException("Number of rows and columns must be positive non-zero integers.");
        }

        unsafe
        {
            fixed (ComplexDouble* pA = a)
            {
                sbyte transByte = (sbyte)trans;
                sbyte orderByte = (sbyte)order;
                OpenBlas.Zimatcopy(&transByte, &orderByte, &rows, &cols, &alpha, pA, &rows, &cols);
            }
        }
    }
}