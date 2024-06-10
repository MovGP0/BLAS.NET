using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Complex32;

namespace OpenBLAS.Conversions;

public static partial class GeneralMatrix
{
    /// <summary>
    /// Convert a General Matrix to a <see cref="DenseMatrix"/>
    /// </summary>
    public static DenseMatrix FromBlas(ComplexFloat[] matrix, int rows, int columns)
    {
        return DenseMatrix.OfArray(To2DArray(matrix, rows, columns));
    }

    /// <summary>
    /// Convert a <see cref="DenseMatrix"/> to a General Matrix
    /// </summary>
    public static ComplexFloat[] ToBlas(DenseMatrix matrix)
    {
        return matrix
            .AsColumnMajorArray()
            .Select(c => new ComplexFloat(c.Real, c.Imaginary))
            .ToArray();
    }

    private static Complex32[,] To2DArray(ComplexFloat[] array, int rows, int columns)
    {
        var result = new Complex32[rows, columns];
        for (var i = 0; i < array.Length; i++)
        {
            var c = array[i];
            result[i / columns, i % columns] = new(c.Real, c.Imaginary);
        }

        return result;
    }
}