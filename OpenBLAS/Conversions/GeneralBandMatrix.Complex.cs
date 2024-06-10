using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Complex;

namespace OpenBLAS.Conversions;

public static partial class GeneralBandMatrix
{
    public static DenseMatrix BandToDense(Complex[][] bands, int rows, int columns)
    {
        var matrix = DenseMatrix.OfArray(new Complex[rows, columns]);
        var bandCount = bands.Length;

        for (var i = 0; i < bandCount; i++)
        {
            for (var j = 0; j < bands[i].Length; j++)
            {
                var row = j;
                var col = j + i;
                if (col < columns)
                {
                    matrix[row, col] = bands[i][j];
                    matrix[col, row] = bands[i][j]; // Symmetric fill
                }
            }
        }

        return matrix;
    }

    public static Complex[][] DenseToBand(DenseMatrix matrix, int bandwidth)
    {
        var rows = matrix.RowCount;
        var bands = new Complex[bandwidth][];
        for (var i = 0; i < bandwidth; i++)
        {
            bands[i] = new Complex[Math.Max(0, rows - i)];
            for (var j = 0; j < bands[i].Length; j++)
            {
                bands[i][j] = matrix[j, j + i];
            }
        }

        return bands;
    }
}