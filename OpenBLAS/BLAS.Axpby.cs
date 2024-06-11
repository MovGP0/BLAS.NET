using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for single-precision floats.
    /// </summary>
    /// <param name="alpha">The scalar alpha.</param>
    /// <param name="x">The single-precision float vector X.</param>
    /// <param name="incX">The increment for the elements of X.</param>
    /// <param name="beta">The scalar beta.</param>
    /// <param name="y">The single-precision float vector Y.</param>
    /// <param name="incY">The increment for the elements of Y.</param>
    /// <returns>A new single-precision float vector that is the result of the operation.</returns>
    public static float[] Axpby(float alpha, float[] x, int incX, float beta, float[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        var n = x.Length;

        unsafe
        {
            fixed (float* pX = x, pY = y)
            {
                OpenBlas.Saxpby(&n, &alpha, pX, &incX, &beta, pY, &incY);
            }
        }

        return y;
    }

    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for double-precision floats.
    /// </summary>
    /// <param name="alpha">The scalar alpha.</param>
    /// <param name="x">The double-precision float vector X.</param>
    /// <param name="incX">The increment for the elements of X.</param>
    /// <param name="beta">The scalar beta.</param>
    /// <param name="y">The double-precision float vector Y.</param>
    /// <param name="incY">The increment for the elements of Y.</param>
    /// <returns>A new double-precision float vector that is the result of the operation.</returns>
    public static double[] Axpby(double alpha, double[] x, int incX, double beta, double[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        var n = x.Length;

        unsafe
        {
            fixed (double* pX = x, pY = y)
            {
                OpenBlas.Daxpby(&n, &alpha, pX, &incX, &beta, pY, &incY);
            }
        }

        return y;
    }

    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for single-precision complex floats.
    /// </summary>
    /// <param name="alpha">The scalar alpha.</param>
    /// <param name="x">The single-precision complex float vector X.</param>
    /// <param name="incX">The increment for the elements of X.</param>
    /// <param name="beta">The scalar beta.</param>
    /// <param name="y">The single-precision complex float vector Y.</param>
    /// <param name="incY">The increment for the elements of Y.</param>
    /// <returns>A new single-precision complex float vector that is the result of the operation.</returns>
    public static ComplexFloat[] Axpby(ComplexFloat alpha, ComplexFloat[] x, int incX, ComplexFloat beta, ComplexFloat[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        var n = x.Length;

        unsafe
        {
            fixed (ComplexFloat* pX = x, pY = y)
            {
                OpenBlas.Caxpby(&n, &alpha, pX, &incX, &beta, pY, &incY);
            }
        }

        return y;
    }

    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for double-precision complex floats.
    /// </summary>
    /// <param name="n">The number of elements in the vectors.</param>
    /// <param name="alpha">The scalar alpha.</param>
    /// <param name="x">The double-precision complex float vector X.</param>
    /// <param name="incX">The increment for the elements of X.</param>
    /// <param name="beta">The scalar beta.</param>
    /// <param name="y">The double-precision complex float vector Y.</param>
    /// <param name="incY">The increment for the elements of Y.</param>
    /// <returns>A new double-precision complex float vector that is the result of the operation.</returns>
    public static ComplexDouble[] Axpby(ComplexDouble alpha, ComplexDouble[] x, int incX, ComplexDouble beta, ComplexDouble[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        var n = x.Length;

        unsafe
        {
            fixed (ComplexDouble* pX = x, pY = y)
            {
                OpenBlas.Zaxpby(&n, &alpha, pX, &incX, &beta, pY, &incY);
            }
        }

        return y;
    }

    /// <summary>
    /// Perform the operation y = a* * x + y, where x and y are single-precision complex vectors, and a* is the complex conjugate of a single-precision complex scalar.
    /// </summary>
    /// <param name="a">The single-precision complex scalar.</param>
    /// <param name="x">The single-precision complex vector x.</param>
    /// <param name="incX">The increment for the elements of the vector x.</param>
    /// <param name="y">The single-precision complex vector y.</param>
    /// <param name="incY">The increment for the elements of the vector y.</param>
    /// <returns>A new single-precision complex vector that is the result of the operation.</returns>
    [Obsolete("not supported", true)]
    public static ComplexFloat[] Axpyc(ComplexFloat a, ComplexFloat[] x, int incX, ComplexFloat[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        var n = x.Length;

        unsafe
        {
            fixed (ComplexFloat* pY = y, pX = x)
            {
                OpenBlas.Caxpyc(&n, &a, pX, &incX, pY, &incY);
            }
        }

        return y;
    }

    /// <summary>
    /// Perform the operation y = a* * x + y, where x and y are double-precision complex vectors, and a* is the complex conjugate of a double-precision complex scalar.
    /// </summary>
    /// <param name="a">The double-precision complex scalar.</param>
    /// <param name="x">The double-precision complex vector x.</param>
    /// <param name="incX">The increment for the elements of the vector x.</param>
    /// <param name="y">The double-precision complex vector y.</param>
    /// <param name="incY">The increment for the elements of the vector y.</param>
    /// <returns>A new double-precision complex vector that is the result of the operation.</returns>
    [Obsolete("not supported", true)]
    public static ComplexDouble[] Axpyc(ComplexDouble a, ComplexDouble[] x, int incX, ComplexDouble[] y, int incY)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (x.Length / incX != y.Length / incY)
        {
            throw new ArgumentException(nameof(y));
        }

        var n = x.Length;

        unsafe
        {
            fixed (ComplexDouble* pY = y, pX = x)
            {
                OpenBlas.Zaxpyc(&n, &a, pX, &incX, pY, &incY);
            }
        }

        return y;
    }
}
