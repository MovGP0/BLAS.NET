using OpenBLAS.PInvoke;

namespace OpenBLAS;

public static partial class BLAS
{
    /// <summary>
    /// Find the index of the element with the maximum absolute value in a single-precision float vector.
    /// </summary>
    /// <param name="values">The single-precision float vector.</param>
    /// <param name="increment">The increment for the elements of the vector.</param>
    /// <returns>The index of the element with the maximum absolute value in the vector.</returns>
    public static int IndexOfAbsoluteMaxValue(float[] values, int increment)
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
                return OpenBlas.Isamax(&n, pX, &increment) - 1;
            }
        }
    }

    /// <summary>
    /// Find the index of the element with the maximum absolute value in a double-precision float vector.
    /// </summary>
    /// <param name="values">The double-precision float vector.</param>
    /// <param name="increment">The increment for the elements of the vector.</param>
    /// <returns>The index of the element with the maximum absolute value in the vector.</returns>
    public static int IndexOfAbsoluteMaxValue(double[] values, int increment)
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
                return OpenBlas.Idamax(&n, pX, &increment) - 1;
            }
        }
    }

    /// <summary>
    /// Find the index of the element with the maximum absolute value in a single-precision complex vector.
    /// </summary>
    /// <param name="values">The single-precision complex vector.</param>
    /// <param name="increment">The increment for the elements of the vector.</param>
    /// <returns>The index of the element with the maximum absolute value in the vector.</returns>
    public static int IndexOfAbsoluteMaxValue(ComplexFloat[] values, int increment)
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
                return OpenBlas.Icamax(&n, pX, &increment) - 1;
            }
        }
    }

    /// <summary>
    /// Find the index of the element with the maximum absolute value in a double-precision complex vector.
    /// </summary>
    /// <param name="values">The double-precision complex vector.</param>
    /// <param name="increment">The increment for the elements of the vector.</param>
    /// <returns>The index of the element with the maximum absolute value in the vector.</returns>
    public static int IndexOfAbsoluteMaxValue(ComplexDouble[] values, int increment)
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
                return OpenBlas.Izamax(&n, pX, &increment) - 1;
            }
        }
    }
}
