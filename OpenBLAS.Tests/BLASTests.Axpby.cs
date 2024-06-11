namespace OpenBLAS.Tests;

public static partial class BLASTests
{
    [TestOf(nameof(BLAS.Axpby))]
    public sealed class AxpbyTests
    {
        [Fact]
        public void Axpby_ShouldPerformCorrectly_ForSinglePrecision()
        {
            // Arrange
            const float alpha = 2.0f;
            const float beta = 3.0f;
            float[] x = [1.0f, 2.0f, 3.0f];
            float[] y = [4.0f, 5.0f, 6.0f];
            const int incX = 1;
            const int incY = 1;

            // Act
            var result = BLAS.Axpby(alpha, x, incX, beta, y, incY);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r[0].ShouldBe(14.0f),
                r => r[1].ShouldBe(19.0f),
                r => r[2].ShouldBe(24.0f)
            );
        }

        [Fact]
        public void Axpby_ShouldPerformCorrectly_ForDoublePrecision()
        {
            // Arrange
            const double alpha = 2.0;
            const double beta = 3.0;
            double[] x = [1.0, 2.0, 3.0];
            double[] y = [4.0, 5.0, 6.0];
            const int incX = 1;
            const int incY = 1;

            // Act
            var result = BLAS.Axpby(alpha, x, incX, beta, y, incY);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r[0].ShouldBe(14.0),
                r => r[1].ShouldBe(19.0),
                r => r[2].ShouldBe(24.0)
            );
        }

        [Fact]
        public void Axpby_ShouldPerformCorrectly_ForSinglePrecisionComplex()
        {
            // Arrange
            ComplexFloat alpha = new(2.0f, 3.0f);
            ComplexFloat beta = new(3.0f, 2.0f);
            ComplexFloat[] x = [new(1.0f, 1.0f), new(2.0f, 2.0f)];
            ComplexFloat[] y = [new(3.0f, 3.0f), new(4.0f, 4.0f)];
            const int incX = 1;
            const int incY = 1;

            // Act
            var result = BLAS.Axpby(alpha, x, incX, beta, y, incY);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r[0].ShouldBe(new ComplexFloat(2.0f, 20.0f)),
                r => r[1].ShouldBe(new ComplexFloat(2.0f, 30.0f))
            );
        }

        [Fact]
        public void Axpby_ShouldPerformCorrectly_ForDoublePrecisionComplex()
        {
            // Arrange
            ComplexDouble alpha = new(2.0, 3.0);
            ComplexDouble beta = new(3.0, 2.0);
            ComplexDouble[] x = [new(1.0, 1.0), new(2.0, 2.0)];
            ComplexDouble[] y = [new(3.0, 3.0), new(4.0, 4.0)];
            const int incX = 1;
            const int incY = 1;

            // Act
            var result = BLAS.Axpby(alpha, x, incX, beta, y, incY);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r[0].ShouldBe(new ComplexDouble(2.0, 20.0)),
                r => r[1].ShouldBe(new ComplexDouble(2.0, 30.0))
            );
        }

        [Fact]
        public void Axpby_ShouldThrowArgumentException_ForZeroLengthVector()
        {
            // Arrange
            const float alpha = 2.0f;
            const float beta = 3.0f;
            float[] x = [];
            float[] y = [4.0f, 5.0f, 6.0f];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpby(alpha, x, incX, beta, y, incY));
        }

        [Fact]
        public void Axpby_ShouldThrowArgumentException_ForMismatchedLengthVectors()
        {
            // Arrange
            const float alpha = 2.0f;
            const float beta = 3.0f;
            float[] x = [1.0f, 2.0f, 3.0f];
            float[] y = [4.0f, 5.0f];
            const int incX = 1;
            const int incY = 1;

            // Act & Assert
            Should.Throw<ArgumentException>(() => BLAS.Axpby(alpha, x, incX, beta, y, incY));
        }
    }
}