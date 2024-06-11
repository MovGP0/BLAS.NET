using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Compute the sum of absolute values of elements in a single-precision vector.
    /// </summary>
    /// <param name="x">The single-precision vector.</param>
    /// <param name="incX">The increment for the elements of the vector.</param>
    /// <returns>The sum of absolute values of elements in the vector.</returns>
    public static float Asum(float[] x, int incX)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (incX <= 0)
        {
            throw new ArgumentException(nameof(incX));
        }

        if (x.Length % incX != 0)
        {
            throw new ArgumentException(nameof(incX));
        }

        var n = x.Length;

        unsafe
        {
            fixed (float* pX = x)
            {
                return OpenBlas.Sasum(&n, pX, &incX);
            }
        }
    }

    /// <summary>
    /// Compute the sum of absolute values of elements in a double-precision vector.
    /// </summary>
    /// <param name="x">The double-precision vector.</param>
    /// <param name="incX">The increment for the elements of the vector.</param>
    /// <returns>The sum of absolute values of elements in the vector.</returns>
    public static double Asum(double[] x, int incX)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (incX <= 0)
        {
            throw new ArgumentException(nameof(incX));
        }

        if (x.Length % incX != 0)
        {
            throw new ArgumentException(nameof(incX));
        }

        var n = x.Length;

        unsafe
        {
            fixed (double* pX = x)
            {
                return OpenBlas.Dasum(&n, pX, &incX);
            }
        }
    }

    /// <summary>
    /// Compute the sum of absolute values of elements in a single-precision complex vector.
    /// </summary>
    /// <param name="x">The single-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the vector.</param>
    /// <returns>The sum of absolute values of elements in the vector.</returns>
    public static float Asum(ComplexFloat[] x, int incX)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (incX <= 0)
        {
            throw new ArgumentException(nameof(incX));
        }

        if (x.Length % incX != 0)
        {
            throw new ArgumentException(nameof(incX));
        }

        var n = x.Length;

        unsafe
        {
            fixed (ComplexFloat* pX = x)
            {
                return OpenBlas.Casum(&n, pX, &incX);
            }
        }
    }

    /// <summary>
    /// Compute the sum of absolute values of elements in a double-precision complex vector.
    /// </summary>
    /// <param name="x">The double-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the vector.</param>
    /// <returns>The sum of absolute values of elements in the vector.</returns>
    public static double Asum(ComplexDouble[] x, int incX)
    {
        if (x.Length == 0)
        {
            throw new ArgumentException();
        }

        if (incX <= 0)
        {
            throw new ArgumentException(nameof(incX));
        }

        if (x.Length % incX != 0)
        {
            throw new ArgumentException(nameof(incX));
        }

        var n = x.Length;

        unsafe
        {
            fixed (ComplexDouble* pX = x)
            {
                return OpenBlas.Zasum(&n, pX, &incX);
            }
        }
    }
}