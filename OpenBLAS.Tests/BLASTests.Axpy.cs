namespace OpenBLAS.Tests;

public static partial class BLASTests
{
    [TestOf(nameof(BLAS.Axpy))]
    public sealed class AxpyTests
    {
        [Fact]
        public void Axpy_ShouldPerformCorrectly_ForSinglePrecision()
        {
            // Arrange
            const float a = 2.0f;
            float[] x = [1.0f, 2.0f, 3.0f];
            float[] y = [4.0f, 5.0f, 6.0f];
            const int incX = 1;
            const int incY = 1;

            // Act
            var result = BLAS.Axpy(a, x, incX, y, incY);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r[0].ShouldBe(6.0f),
                r => r[1].ShouldBe(9.0f),
                r => r[2].ShouldBe(12.0f)
            );
        }

        [Fact]
        public void Axpy_ShouldThrowArgumentException_ForZeroLengthVector()
        {
            // Arrange
            const float a = 2.0f;
            float[] x = [];
            float[] y = [4.0f, 5.0f, 6.0f];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpy(a, x, incX, y, incY));
        }

        [Fact]
        public void Axpy_ShouldThrowArgumentException_ForMismatchedLengthVectors()
        {
            // Arrange
            const float a = 2.0f;
            float[] x = [1.0f, 2.0f, 3.0f];
            float[] y = [4.0f, 5.0f];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpy(a, x, incX, y, incY));
        }

        [Fact]
        public void Axpy_ShouldPerformCorrectly_ForDoublePrecision()
        {
            // Arrange
            const double a = 2.0;
            double[] x = [1.0, 2.0, 3.0];
            double[] y = [4.0, 5.0, 6.0];
            const int incX = 1;
            const int incY = 1;

            // Act
            var result = BLAS.Axpy(a, x, incX, y, incY);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r[0].ShouldBe(6.0),
                r => r[1].ShouldBe(9.0),
                r => r[2].ShouldBe(12.0)
            );
        }

        [Fact]
        public void Axpy_ShouldThrowArgumentException_ForZeroLengthVector_Double()
        {
            // Arrange
            const double a = 2.0;
            double[] x = [];
            double[] y = [4.0, 5.0, 6.0];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpy(a, x, incX, y, incY));
        }

        [Fact]
        public void Axpy_ShouldThrowArgumentException_ForMismatchedLengthVectors_Double()
        {
            // Arrange
            const double a = 2.0;
            double[] x = [1.0, 2.0, 3.0];
            double[] y = [4.0, 5.0];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpy(a, x, incX, y, incY));
        }

        [Fact]
        public void Axpy_ShouldPerformCorrectly_ForSinglePrecisionComplex()
        {
            // Arrange
            ComplexFloat a = new(2.0f, 3.0f);
            ComplexFloat[] x = [new(1.0f, 1.0f), new(2.0f, 2.0f)];
            ComplexFloat[] y = [new(3.0f, 3.0f), new(4.0f, 4.0f)];
            const int incX = 1;
            const int incY = 1;

            // Act
            var result = BLAS.Axpy(a, x, incX, y, incY);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r[0].ShouldBe(new ComplexFloat(2.0f, 8.0f)),
                r => r[1].ShouldBe(new ComplexFloat(2.0f, 14.0f))
            );
        }

        [Fact]
        public void Axpy_ShouldThrowArgumentException_ForZeroLengthVector_SinglePrecisionComplex()
        {
            // Arrange
            ComplexFloat a = new(2.0f, 3.0f);
            ComplexFloat[] x = [];
            ComplexFloat[] y = [new(3.0f, 3.0f), new(4.0f, 4.0f)];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpy(a, x, incX, y, incY));
        }

        [Fact]
        public void Axpy_ShouldThrowArgumentException_ForMismatchedLengthVectors_SinglePrecisionComplex()
        {
            // Arrange
            ComplexFloat a = new(2.0f, 3.0f);
            ComplexFloat[] x = [new(1.0f, 1.0f)];
            ComplexFloat[] y = [new(3.0f, 3.0f), new(4.0f, 4.0f)];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpy(a, x, incX, y, incY));
        }

        [Fact]
        public void Axpy_ShouldPerformCorrectly_ForDoublePrecisionComplex()
        {
            // Arrange
            ComplexDouble a = new(2.0, 3.0);
            ComplexDouble[] x = [new(1.0, 1.0), new(2.0, 2.0)];
            ComplexDouble[] y = [new(3.0, 3.0), new(4.0, 4.0)];
            const int incX = 1;
            const int incY = 1;

            // Act
            var result = BLAS.Axpy(a, x, incX, y, incY);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r[0].ShouldBe(new ComplexDouble(2.0, 8.0)),
                r => r[1].ShouldBe(new ComplexDouble(2.0, 14.0))
            );
        }

        [Fact]
        public void Axpy_ShouldThrowArgumentException_ForZeroLengthVector_DoublePrecisionComplex()
        {
            // Arrange
            ComplexDouble a = new(2.0, 3.0);
            ComplexDouble[] x = [];
            ComplexDouble[] y = [new(3.0, 3.0), new(4.0, 4.0)];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpy(a, x, incX, y, incY));
        }

        [Fact]
        public void Axpy_ShouldThrowArgumentException_ForMismatchedLengthVectors_DoublePrecisionComplex()
        {
            // Arrange
            ComplexDouble a = new(2.0, 3.0);
            ComplexDouble[] x = [new(1.0, 1.0)];
            ComplexDouble[] y = [new(3.0, 3.0), new(4.0, 4.0)];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpy(a, x, incX, y, incY));
        }
    }
}