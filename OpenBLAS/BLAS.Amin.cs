using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Find the index of the element with the minimum absolute value in a single-precision float vector.
    /// </summary>
    /// <param name="values">The single-precision float vector.</param>
    /// <param name="increment">The increment for the elements of the vector.</param>
    /// <returns>The index of the element with the minimum absolute value in the vector.</returns>
    public static int IndexOfAbsoluteMinValue(float[] values, int increment)
    {
        if (increment <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(increment));
        }

        if (values.Length == 0)
        {
            throw new ArgumentException(nameof(values));
        }

        var n = values.Length;
        unsafe
        {
            fixed (float* pX = values)
            {
                return OpenBlas.Isamin(&n, pX, &increment) - 1;
            }
        }
    }

    /// <summary>
    /// Find the index of the element with the minimum absolute value in a double-precision float vector.
    /// </summary>
    /// <param name="values">The double-precision float vector.</param>
    /// <param name="increment">The increment for the elements of the vector.</param>
    /// <returns>The index of the element with the minimum absolute value in the vector.</returns>
    public static int IndexOfAbsoluteMinValue(double[] values, int increment)
    {
        if (increment <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(increment));
        }

        if (values.Length == 0)
        {
            throw new ArgumentException(nameof(values));
        }

        var n = values.Length;
        unsafe
        {
            fixed (double* pX = values)
            {
                return OpenBlas.Idamin(&n, pX, &increment) - 1;
            }
        }
    }

    /// <summary>
    /// Find the index of the element with the minimum absolute value in a complex single-precision float vector.
    /// </summary>
    /// <param name="values">The complex single-precision float vector.</param>
    /// <param name="increment">The increment for the elements of the vector.</param>
    /// <returns>The index of the element with the minimum absolute value in the vector.</returns>
    public static int IndexOfAbsoluteMinValue(ComplexFloat[] values, int increment)
    {
        if (increment <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(increment));
        }

        if (values.Length == 0)
        {
            throw new ArgumentException(nameof(values));
        }

        var n = values.Length;
        unsafe
        {
            fixed (ComplexFloat* pX = values)
            {
                return OpenBlas.Icamin(&n, pX, &increment) - 1;
            }
        }
    }

    /// <summary>
    /// Find the index of the element with the minimum absolute value in a complex double-precision float vector.
    /// </summary>
    /// <param name="n">The number of elements in the vector.</param>
    /// <param name="values">The complex double-precision float vector.</param>
    /// <param name="increment">The increment for the elements of the vector.</param>
    /// <returns>The index of the element with the minimum absolute value in the vector.</returns>
    public static int IndexOfAbsoluteMinValue(ComplexDouble[] values, int increment)
    {
        if (increment <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(increment));
        }

        if (values.Length == 0)
        {
            throw new ArgumentException(nameof(values));
        }

        var n = values.Length;
        unsafe
        {
            fixed (ComplexDouble* pX = values)
            {
                return OpenBlas.Izamin(&n, pX, &increment) - 1;
            }
        }
    }
}
