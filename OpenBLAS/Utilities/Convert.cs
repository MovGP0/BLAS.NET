namespace OpenBLAS;

/// <summary>
/// Provides methods to convert between managed and unmanaged representations of various types.
/// </summary>
internal static class Convert
{
    public static unsafe void ToManaged(ComplexFloat* nativeArray, ComplexFloat[] managedArray)
    {
        for (int i = 0; i < managedArray.Length; i++)
        {
            managedArray[i].Real = nativeArray[i].Real;
            managedArray[i].Imaginary = nativeArray[i].Imaginary;
        }
    }

    /// <summary>
    /// Converts an unmanaged single-precision floating-point matrix to its managed representation.
    /// </summary>
    /// <param name="nativeMatrix">A pointer to the unmanaged representation of the matrix.</param>
    /// <param name="managedMatrix">The managed single-precision floating-point matrix.</param>
    internal static unsafe void ToManaged(float* nativeMatrix, float[,] managedMatrix)
    {
        var rows = managedMatrix.GetLength(0);
        var columns = managedMatrix.GetLength(1);

        for (var i = 0; i < rows; i++)
        for (var j = 0; j < columns; j++)
        {
            managedMatrix[i, j] = nativeMatrix[i * columns + j];
        }
    }

    /// <summary>
    /// Converts an unmanaged single-precision floating-point vector to its managed representation.
    /// </summary>
    /// <param name="nativeVector">A pointer to the unmanaged representation of the vector.</param>
    /// <param name="managedVector">The managed single-precision floating-point vector.</param>
    internal static unsafe void ToManaged(float* nativeVector, float[] managedVector)
    {
        var length = managedVector.Length;

        for (var i = 0; i < length; i++)
        {
            managedVector[i] = nativeVector[i];
        }
    }

    /// <summary>
    /// Converts an unmanaged double-precision floating-point matrix to its managed representation.
    /// </summary>
    /// <param name="nativeMatrix">A pointer to the unmanaged representation of the matrix.</param>
    /// <param name="managedMatrix">The managed double-precision floating-point matrix.</param>
    internal static unsafe void ToManaged(double* nativeMatrix, double[,] managedMatrix)
    {
        var rows = managedMatrix.GetLength(0);
        var columns = managedMatrix.GetLength(1);

        for (var i = 0; i < rows; i++)
        for (var j = 0; j < columns; j++)
        {
            managedMatrix[i, j] = nativeMatrix[i * columns + j];
        }
    }

    /// <summary>
    /// Converts an unmanaged double-precision floating-point vector to its managed representation.
    /// </summary>
    /// <param name="nativeVector">A pointer to the unmanaged representation of the vector.</param>
    /// <param name="managedVector">The managed double-precision floating-point vector.</param>
    internal static unsafe void ToManaged(double* nativeVector, double[] managedVector)
    {
        var length = managedVector.Length;

        for (var i = 0; i < length; i++)
        {
            managedVector[i] = nativeVector[i];
        }
    }

    /// <summary>
    /// Converts an unmanaged complex double-precision floating-point matrix to its managed representation.
    /// </summary>
    /// <param name="nativeMatrix">A pointer to the unmanaged representation of the matrix.</param>
    /// <param name="managedMatrix">The managed complex double-precision floating-point matrix.</param>
    internal static unsafe void ToManaged(ComplexDouble* nativeMatrix, ComplexDouble[,] managedMatrix)
    {
        var rows = managedMatrix.GetLength(0);
        var columns = managedMatrix.GetLength(1);

        for (var i = 0; i < rows; i++)
        for (var j = 0; j < columns; j++)
        {
            managedMatrix[i, j] = new ComplexDouble
            {
                Real = nativeMatrix[i * columns + j].Real,
                Imaginary = nativeMatrix[i * columns + j].Imaginary
            };
        }
    }

    /// <summary>
    /// Converts an unmanaged complex double-precision floating-point vector to its managed representation.
    /// </summary>
    /// <param name="nativeVector">A pointer to the unmanaged representation of the vector.</param>
    /// <param name="managedVector">The managed complex double-precision floating-point vector.</param>
    internal static unsafe void ToManaged(ComplexDouble* nativeVector, ComplexDouble[] managedVector)
    {
        var length = managedVector.Length;

        for (var i = 0; i < length; i++)
        {
            managedVector[i] = new ComplexDouble
            {
                Real = nativeVector[i].Real,
                Imaginary = nativeVector[i].Imaginary
            };
        }
    }

    /// <summary>
    /// Converts an unmanaged complex single-precision floating-point matrix to its managed representation.
    /// </summary>
    /// <param name="nativeMatrix">A pointer to the unmanaged representation of the matrix.</param>
    /// <param name="managedMatrix">The managed complex single-precision floating-point matrix.</param>
    internal static unsafe void ToManaged(ComplexFloat* nativeMatrix, ComplexFloat[,] managedMatrix)
    {
        var rows = managedMatrix.GetLength(0);
        var columns = managedMatrix.GetLength(1);

        for (var i = 0; i < rows; i++)
        for (var j = 0; j < columns; j++)
        {
            managedMatrix[i, j] = new ComplexFloat
            {
                Real = nativeMatrix[i * columns + j].Real,
                Imaginary = nativeMatrix[i * columns + j].Imaginary
            };
        }
    }
}
