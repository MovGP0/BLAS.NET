namespace OpenBLAS.Tests;

public static partial class BLASTests
{
    [TestOf(nameof(BLAS.Asum))]
    public sealed class AsumTests
    {
        [Fact]
        public void Asum_ShouldComputeSumOfAbsoluteValues_ForSinglePrecision()
        {
            // Arrange
            float[] x = [-1.0f, -2.0f, -3.0f];
            const int incX = 1;

            // Act
            var result = BLAS.Asum(x, incX);

            // Assert
            result.ShouldBe(6.0f);
        }

        [Fact]
        public void Asum_ShouldThrowArgumentException_ForZeroLengthVector_SinglePrecision()
        {
            // Arrange
            float[] x = [];
            const int incX = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Asum(x, incX));
        }

        [Fact]
        public void Asum_ShouldThrowArgumentException_ForInvalidIncrement_SinglePrecision()
        {
            // Arrange
            float[] x = [1.0f, 2.0f, 3.0f];
            const int incX = 0;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Asum(x, incX));
        }

        [Fact]
        public void Asum_ShouldComputeSumOfAbsoluteValues_ForDoublePrecision()
        {
            // Arrange
            double[] x = [-1.0, -2.0, -3.0];
            const int incX = 1;

            // Act
            var result = BLAS.Asum(x, incX);

            // Assert
            result.ShouldBe(6.0);
        }

        [Fact]
        public void Asum_ShouldThrowArgumentException_ForZeroLengthVector_DoublePrecision()
        {
            // Arrange
            double[] x = [];
            const int incX = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Asum(x, incX));
        }

        [Fact]
        public void Asum_ShouldThrowArgumentException_ForInvalidIncrement_DoublePrecision()
        {
            // Arrange
            double[] x = [1.0, 2.0, 3.0];
            const int incX = 0;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Asum(x, incX));
        }

        [Fact]
        public void Asum_ShouldComputeSumOfAbsoluteValues_ForSinglePrecisionComplex()
        {
            // Arrange
            ComplexFloat[] x = [new(-1.0f, 1.0f), new(-2.0f, 2.0f), new(-3.0f, 3.0f)];
            const int incX = 1;

            // Act
            var result = BLAS.Asum(x, incX);

            // Assert
            result.ShouldBe(12.0f);
        }

        [Fact]
        public void Asum_ShouldThrowArgumentException_ForZeroLengthVector_SinglePrecisionComplex()
        {
            // Arrange
            ComplexFloat[] x = [];
            const int incX = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Asum(x, incX));
        }

        [Fact]
        public void Asum_ShouldThrowArgumentException_ForInvalidIncrement_SinglePrecisionComplex()
        {
            // Arrange
            ComplexFloat[] x = [new(1.0f, 1.0f), new(2.0f, 2.0f), new(3.0f, 3.0f)];
            const int incX = 0;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Asum(x, incX));
        }

        [Fact]
        public void Asum_ShouldComputeSumOfAbsoluteValues_ForDoublePrecisionComplex()
        {
            // Arrange
            ComplexDouble[] x = [new(-1.0, 1.0), new(-2.0, 2.0), new(-3.0, 3.0)];
            const int incX = 1;

            // Act
            var result = BLAS.Asum(x, incX);

            // Assert
            result.ShouldBe(12.0);
        }

        [Fact]
        public void Asum_ShouldThrowArgumentException_ForZeroLengthVector_DoublePrecisionComplex()
        {
            // Arrange
            ComplexDouble[] x = [];
            const int incX = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Asum(x, incX));
        }

        [Fact]
        public void Asum_ShouldThrowArgumentException_ForInvalidIncrement_DoublePrecisionComplex()
        {
            // Arrange
            ComplexDouble[] x = [new(1.0, 1.0), new(2.0, 2.0), new(3.0, 3.0)];
            const int incX = 0;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Asum(x, incX));
        }
    }
}