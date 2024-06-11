using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Perform the operation y = a * x + y, where x and y are single-precision vectors, and a is a single-precision scalar.
    /// </summary>
    /// <param name="a">The single-precision scalar.</param>
    /// <param name="x">The first single-precision vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second single-precision vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>A new single-precision float vector that is the result of the operation.</returns>
    public static float[] Axpy(float a, float[] x, int incX, float[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException(nameof(x));
        }

        if (y.Length == 0)
        {
            throw new ArgumentException(nameof(y));
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        var n = x.Length;

        unsafe
        {
            fixed (float* pY = y, pX = x)
            {
                OpenBlas.Saxpy(&n, &a, pX, &incX, pY, &incY);
            }
        }

        return y;
    }

    /// <summary>
    /// Perform the operation y = a * x + y, where x* and y* are double-precision vectors, and a is a double-precision scalar.
    /// </summary>
    /// <param name="a">The double-precision scalar.</param>
    /// <param name="x">The first double-precision vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second double-precision vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>A new double-precision float vector that is the result of the operation.</returns>
    public static double[] Axpy(double a, double[] x, int incX, double[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException(nameof(x));
        }

        if (y.Length == 0)
        {
            throw new ArgumentException(nameof(y));
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        var n = x.Length;

        unsafe
        {
            fixed (double* pY = y, pX = x)
            {
                OpenBlas.Daxpy(&n, &a, pX, &incX, pY, &incY);
            }
        }

        return y;
    }

    /// <summary>
    /// Perform the operation y = a * x + y, where x and y are single-precision complex vectors, and a is a single-precision complex scalar.
    /// </summary>
    /// <param name="a">The single-precision complex scalar.</param>
    /// <param name="x">The first single-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second single-precision complex vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>A new single-precision complex float vector that is the result of the operation.</returns>
    public static ComplexFloat[] Axpy(ComplexFloat a, ComplexFloat[] x, int incX, ComplexFloat[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException(nameof(x));
        }

        if (y.Length == 0)
        {
            throw new ArgumentException(nameof(y));
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        int n = x.Length;

        unsafe
        {
            fixed(ComplexFloat* pX = x, pY = y)
            {
                OpenBlas.Caxpy(&n, &a, pX, &incX, pY, &incY);
            }
        }

        return y;
    }

    /// <summary>
    /// Perform the operation y = a * x + y, where x and y are double-precision complex vectors, and a is a double-precision complex scalar.
    /// </summary>
    /// <param name="a">The double-precision complex scalar.</param>
    /// <param name="x">The first double-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second double-precision complex vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>A new double-precision complex float vector that is the result of the operation.</returns>
    public static ComplexDouble[] Axpy(ComplexDouble a, ComplexDouble[] x, int incX, ComplexDouble[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException(nameof(x));
        }

        if (y.Length == 0)
        {
            throw new ArgumentException(nameof(y));
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        int n = x.Length;

        unsafe
        {
            fixed(ComplexDouble* pX = x, pY = y)
            {
                OpenBlas.Zaxpy(&n, &a, pX, &incX, pY, &incY);
            }
        }

        return y;
    }
}
