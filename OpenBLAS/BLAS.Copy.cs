using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Copy the contents of one single-precision vector to another.
    /// </summary>
    /// <param name="x">The source single-precision vector.</param>
    /// <param name="incX">The increment for the elements of the source vector.</param>
    /// <param name="y">The destination single-precision vector.</param>
    /// <param name="incY">The increment for the elements of the destination vector.</param>
    public static void Copy(float[] x, int incX, float[] y, int incY)
    {
        if (x.Length == 0 || y.Length == 0)
        {
            throw new ArgumentException("Vectors cannot be empty.");
        }

        if (incX <= 0 || incY <= 0)
        {
            throw new ArgumentException("Increments must be positive non-zero integers.");
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException("Vector lengths must be compatible with increments.");
        }

        var n = x.Length / incX;

        unsafe
        {
            fixed (float* pX = x, pY = y)
            {
                OpenBlas.Scopy(&n, pX, &incX, pY, &incY);
            }
        }
    }

    /// <summary>
    /// Copy the contents of one double-precision vector to another.
    /// </summary>
    /// <param name="x">The source double-precision vector.</param>
    /// <param name="incX">The increment for the elements of the source vector.</param>
    /// <param name="y">The destination double-precision vector.</param>
    /// <param name="incY">The increment for the elements of the destination vector.</param>
    public static void Copy(double[] x, int incX, double[] y, int incY)
    {
        if (x.Length == 0 || y.Length == 0)
        {
            throw new ArgumentException("Vectors cannot be empty.");
        }

        if (incX <= 0 || incY <= 0)
        {
            throw new ArgumentException("Increments must be positive non-zero integers.");
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException("Vector lengths must be compatible with increments.");
        }

        var n = x.Length / incX;

        unsafe
        {
            fixed (double* pX = x, pY = y)
            {
                OpenBlas.Dcopy(&n, pX, &incX, pY, &incY);
            }
        }
    }

    /// <summary>
    /// Copy the contents of one single-precision complex vector to another.
    /// </summary>
    /// <param name="x">The source single-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the source vector.</param>
    /// <param name="y">The destination single-precision complex vector.</param>
    /// <param name="incY">The increment for the elements of the destination vector.</param>
    public static void Copy(ComplexFloat[] x, int incX, ComplexFloat[] y, int incY)
    {
        if (x.Length == 0 || y.Length == 0)
        {
            throw new ArgumentException("Vectors cannot be empty.");
        }

        if (incX <= 0 || incY <= 0)
        {
            throw new ArgumentException("Increments must be positive non-zero integers.");
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException("Vector lengths must be compatible with increments.");
        }

        var n = x.Length / incX;

        unsafe
        {
            fixed (ComplexFloat* pX = x, pY = y)
            {
                OpenBlas.Ccopy(&n, pX, &incX, pY, &incY);
            }
        }
    }

    /// <summary>
    /// Copy the contents of one double-precision complex vector to another.
    /// </summary>
    /// <param name="x">The source double-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the source vector.</param>
    /// <param name="y">The destination double-precision complex vector.</param>
    /// <param name="incY">The increment for the elements of the destination vector.</param>
    public static void Copy(ComplexDouble[] x, int incX, ComplexDouble[] y, int incY)
    {
        if (x.Length == 0 || y.Length == 0)
        {
            throw new ArgumentException("Vectors cannot be empty.");
        }

        if (incX <= 0 || incY <= 0)
        {
            throw new ArgumentException("Increments must be positive non-zero integers.");
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException("Vector lengths must be compatible with increments.");
        }

        var n = x.Length / incX;

        unsafe
        {
            fixed (ComplexDouble* pX = x, pY = y)
            {
                OpenBlas.Zcopy(&n, pX, &incX, pY, &incY);
            }
        }
    }
}