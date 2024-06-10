using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Perform the operation y = a * x + y, where x and y are single-precision complex vectors, and a is a single-precision complex scalar.
    /// </summary>
    /// <param name="a">The single-precision complex scalar.</param>
    /// <param name="x">The first single-precision complex vector.</param>
    /// <param name="incX">The increment for the elements of the first vector.</param>
    /// <param name="y">The second single-precision complex vector.</param>
    /// <param name="incY">The increment for the elements of the second vector.</param>
    /// <returns>A new single-precision complex float vector that is the result of the operation.</returns>
    public static ComplexFloat[] Caxpy(ComplexFloat a, ComplexFloat[] x, int incX, ComplexFloat[] y, int incY)
    {
        if (x.Length != y.Length)
            throw new ArgumentException("Vectors x and y must have the same length.");

        int n = x.Length;
        var result = new ComplexFloat[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed(ComplexFloat* pX = x, pY = result)
            {
                OpenBlas.Caxpy(&n, &a, pX, &incX, pY, &incY);
                Convert.ToManaged(pY, result);
            }
        }

        return result;
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
    public static ComplexDouble[] Zaxpy(ComplexDouble a, ComplexDouble[] x, int incX, ComplexDouble[] y, int incY)
    {
        if (x.Length != y.Length)
            throw new ArgumentException("Vectors x and y must have the same length.");

        int n = x.Length;
        var result = new ComplexDouble[y.Length];
        y.CopyTo(result, 0);

        unsafe
        {
            fixed(ComplexDouble* pX = x, pY = result)
            {
                OpenBlas.Zaxpy(&n, &a, pX, &incX, pY, &incY);
                Convert.ToManaged(pY, result);
            }
        }

        return result;
    }
}
