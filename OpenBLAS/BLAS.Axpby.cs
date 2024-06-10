using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for single-precision floats.
    /// </summary>
    /// <param name="n">The number of elements in the vectors.</param>
    /// <param name="alpha">The scalar alpha.</param>
    /// <param name="x">The single-precision float vector X.</param>
    /// <param name="incX">The increment for the elements of X.</param>
    /// <param name="beta">The scalar beta.</param>
    /// <param name="y">The single-precision float vector Y.</param>
    /// <param name="incY">The increment for the elements of Y.</param>
    /// <returns>A new single-precision float vector that is the result of the operation.</returns>
    public static float[] Saxpby(int n, float alpha, float[] x, int incX, float beta, float[] y, int incY)
    {
        var result = new float[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed (float* pX = x, pY = result)
            {
                OpenBlas.Saxpby(&n, &alpha, pX, &incX, &beta, pY, &incY);
            }
        }

        return result;
    }

    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for double-precision floats.
    /// </summary>
    /// <param name="n">The number of elements in the vectors.</param>
    /// <param name="alpha">The scalar alpha.</param>
    /// <param name="x">The double-precision float vector X.</param>
    /// <param name="incX">The increment for the elements of X.</param>
    /// <param name="beta">The scalar beta.</param>
    /// <param name="y">The double-precision float vector Y.</param>
    /// <param name="incY">The increment for the elements of Y.</param>
    /// <returns>A new double-precision float vector that is the result of the operation.</returns>
    public static double[] Daxpby(int n, double alpha, double[] x, int incX, double beta, double[] y, int incY)
    {
        var result = new double[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed (double* pX = x, pY = result)
            {
                OpenBlas.Daxpby(&n, &alpha, pX, &incX, &beta, pY, &incY);
            }
        }

        return result;
    }

    /// <summary>
    /// Perform the operation Y := alpha*X + beta*Y for single-precision complex floats.
    /// </summary>
    /// <param name="n">The number of elements in the vectors.</param>
    /// <param name="alpha">The scalar alpha.</param>
    /// <param name="x">The single-precision complex float vector X.</param>
    /// <param name="incX">The increment for the elements of X.</param>
    /// <param name="beta">The scalar beta.</param>
    /// <param name="y">The single-precision complex float vector Y.</param>
    /// <param name="incY">The increment for the elements of Y.</param>
    /// <returns>A new single-precision complex float vector that is the result of the operation.</returns>
    public static float[] Caxpby(int n, float alpha, float[] x, int incX, float beta, float[] y, int incY)
    {
        var result = new float[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed (float* pX = x, pY = result)
            {
                OpenBlas.Caxpby(&n, &alpha, pX, &incX, &beta, pY, &incY);
            }
        }

        return result;
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
    public static double[] Zaxpby(int n, double alpha, double[] x, int incX, double beta, double[] y, int incY)
    {
        var result = new double[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed (double* pX = x, pY = result)
            {
                OpenBlas.Zaxpby(&n, &alpha, pX, &incX, &beta, pY, &incY);
            }
        }

        return result;
    }

    /// <summary>
    /// Perform the operation y = a * x + y, where x and y are single-precision vectors, and a is a single-precision scalar.
    /// </summary>
    /// <param name="a">The single-precision scalar.</param>
    /// <param name="x">The first single-precision vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second single-precision vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>A new single-precision float vector that is the result of the operation.</returns>
    public static float[] Saxpy(float a, float[] x, int incX, float[] y, int incY)
    {
        if (x.Length != y.Length)
            throw new ArgumentException("Vectors x and y must have the same length.");

        int n = x.Length;
        var result = new float[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed (float* pY = result, pX = x)
            {
                OpenBlas.Saxpy(&n, &a, pX, &incX, pY, &incY);
                Convert.ToManaged(pY, result);
            }
        }

        return result;
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
    public static double[] Daxpy(double a, double[] x, int incX, double[] y, int incY)
    {
        if (x.Length != y.Length)
            throw new ArgumentException("Vectors x and y must have the same length.");

        int n = x.Length;
        var result = new double[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed (double* pY = result, pX = x)
            {
                OpenBlas.Daxpy(&n, &a, pX, &incX, pY, &incY);
                Convert.ToManaged(pY, result);
            }
        }

        return result;
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
    public static ComplexFloat[] Caxpyc(ComplexFloat a, ComplexFloat[] x, int incX, ComplexFloat[] y, int incY)
    {
        if (x.Length != y.Length)
            throw new ArgumentException("Vectors x and y must have the same length.");

        int n = x.Length;
        var result = new ComplexFloat[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed (ComplexFloat* pY = result, pX = x)
            {
                OpenBlas.Caxpyc(&n, &a, pX, &incX, pY, &incY);
                Convert.ToManaged(pY, result);
            }
        }

        return result;
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
    public static ComplexDouble[] Zaxpyc(ComplexDouble a, ComplexDouble[] x, int incX, ComplexDouble[] y, int incY)
    {
        if (x.Length != y.Length)
            throw new ArgumentException("Vectors x and y must have the same length.");

        int n = x.Length;
        var result = new ComplexDouble[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed (ComplexDouble* pY = result, pX = x)
            {
                OpenBlas.Zaxpyc(&n, &a, pX, &incX, pY, &incY);
                Convert.ToManaged(pY, result);
            }
        }

        return result;
    }
}
