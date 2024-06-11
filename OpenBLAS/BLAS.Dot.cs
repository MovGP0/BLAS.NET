using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Compute the dot product of two single-precision vectors.
    /// </summary>
    /// <param name="x">The first single-precision vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second single-precision vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>The dot product of the two vectors.</returns>
    public static float DotProduct(float[] x, int incX, float[] y, int incY)
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
                return OpenBlas.Sdot(&n, pX, &incX, pY, &incY);
            }
        }
    }

    /// <summary>
    /// Compute the dot product of two single-precision vectors, with an added single-precision scalar.
    /// </summary>
    /// <param name="scalar">The single-precision scalar added to the dot product.</param>
    /// <param name="x">The first single-precision vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second single-precision vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>The dot product of the two vectors plus the scalar.</returns>
    public static float DotProductWithScalar(float scalar, float[] x, int incX, float[] y, int incY)
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
                return OpenBlas.Sdsdot(&n, &scalar, pX, &incX, pY, &incY);
            }
        }
    }

    /// <summary>
    /// Compute the dot product of two single-precision vectors, returning a double-precision result.
    /// </summary>
    /// <param name="x">The first single-precision vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second single-precision vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>The double-precision dot product of the two single-precision vectors.</returns>
    public static double DotProductDoublePrecision(float[] x, int incX, float[] y, int incY)
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
                return OpenBlas.Dsdot(&n, pX, &incX, pY, &incY);
            }
        }
    }

    /// <summary>
    /// Compute the dot product of two double-precision vectors.
    /// </summary>
    /// <param name="x">The first double-precision vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second double-precision vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>The dot product of the two double-precision vectors.</returns>
    public static double DotProduct(double[] x, int incX, double[] y, int incY)
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
                return OpenBlas.Ddot(&n, pX, &incX, pY, &incY);
            }
        }
    }

    /// <summary>
    /// Compute the unconjugated dot product of two single-precision complex vectors.
    /// </summary>
    /// <param name="x">The first single-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second single-precision complex vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>The unconjugated dot product of the two single-precision complex vectors.</returns>
    public static ComplexFloat DotProductUnconjugated(ComplexFloat[] x, int incX, ComplexFloat[] y, int incY)
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
                return OpenBlas.Cdotu(&n, pX, &incX, pY, &incY);
            }
        }
    }

    /// <summary>
    /// Compute the unconjugated dot product of two double-precision complex vectors.
    /// </summary>
    /// <param name="x">The first double-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second double-precision complex vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>The unconjugated dot product of the two double-precision complex vectors.</returns>
    public static ComplexDouble DotProductUnconjugated(ComplexDouble[] x, int incX, ComplexDouble[] y, int incY)
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
        var result = new ComplexDouble();

        unsafe
        {
            fixed (ComplexDouble* pX = x, pY = y)
            {
                OpenBlas.Zdotu(&result, &n, pX, &incX, pY, &incY);
            }
        }

        return result;
    }

    /// <summary>
    /// Compute the conjugated dot product of two single-precision complex vectors.
    /// </summary>
    /// <param name="x">The first single-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second single-precision complex vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>The conjugated dot product of the two single-precision complex vectors.</returns>
    public static ComplexFloat DotProductConjugated(ComplexFloat[] x, int incX, ComplexFloat[] y, int incY)
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
                return OpenBlas.Cdotc(&n, pX, &incX, pY, &incY);
            }
        }
    }

    /// <summary>
    /// Compute the conjugated dot product of two double-precision complex vectors.
    /// </summary>
    /// <param name="x">The first double-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second double-precision complex vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>The conjugated dot product of the two double-precision complex vectors.</returns>
    public static ComplexDouble DotProductConjugated(ComplexDouble[] x, int incX, ComplexDouble[] y, int incY)
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

        var result = new ComplexDouble();
        unsafe
        {
            fixed (ComplexDouble* pX = x, pY = y)
            {
                OpenBlas.Zdotc(&result, &n, pX, &incX, pY, &incY);
            }
        }

        return result;
    }
}