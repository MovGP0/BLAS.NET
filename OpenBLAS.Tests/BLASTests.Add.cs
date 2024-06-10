namespace OpenBLAS.Tests;

public static partial class BLASTests
{
    [TestOf(nameof(BLAS.Add))]
    public sealed class AddTests
    {
        [Fact]
        public void ShouldFloatAddValues()
        {
            // Arrange
            float alpha = 1.0f;
            float beta = 1.0f;
            float[,] matrixA = { { 1.0f, 2.0f }, { 3.0f, 4.0f } };
            float[,] matrixB = { { 1.0f, 2.0f }, { 3.0f, 4.0f } };

            // Act
            var result = BLAS.Add(alpha, matrixA, beta, matrixB);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r.Rank.ShouldBe(2),
                r => r.Length.ShouldBe(4),
                r => r[0, 0].ShouldBe(2.0f),
                r => r[0, 1].ShouldBe(4.0f),
                r => r[1, 0].ShouldBe(6.0f),
                r => r[1, 1].ShouldBe(8.0f)
            );
        }

        [Fact]
        public void ShouldAddDoubleValues()
        {
            // Arrange
            double alpha = 1.0d;
            double beta = 1.0d;
            double[,] matrixA = { { 1.0d, 2.0d }, { 3.0d, 4.0d } };
            double[,] matrixB = { { 1.0d, 2.0d }, { 3.0d, 4.0d } };

            // Act
            var result = BLAS.Add(alpha, matrixA, beta, matrixB);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r.Rank.ShouldBe(2),
                r => r.Length.ShouldBe(4),
                r => r[0, 0].ShouldBe(2.0d),
                r => r[0, 1].ShouldBe(4.0d),
                r => r[1, 0].ShouldBe(6.0d),
                r => r[1, 1].ShouldBe(8.0d)
            );
        }

        [Fact]
        public void ShouldAddComplexFloatValues()
        {
            // Arrange
            ComplexFloat alpha = new(1.0f, 0.0f);
            ComplexFloat beta = new(1.0f, 0.0f);
            ComplexFloat[,] matrixA = { { new(1.0f, 0.0f), new(2.0f, 0.0f) }, { new(3.0f, 0.0f), new(4.0f, 0.0f) } };
            ComplexFloat[,] matrixB = { { new(1.0f, 0.0f), new(2.0f, 0.0f) }, { new(3.0f, 0.0f), new(4.0f, 0.0f) } };

            // Act
            var result = BLAS.Add(alpha, matrixA, beta, matrixB);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r.Rank.ShouldBe(2),
                r => r.Length.ShouldBe(4),
                r => r[0, 0].ShouldBe(new ComplexFloat(2.0f, 0.0f)),
                r => r[0, 1].ShouldBe(new ComplexFloat(4.0f, 0.0f)),
                r => r[1, 0].ShouldBe(new ComplexFloat(6.0f, 0.0f)),
                r => r[1, 1].ShouldBe(new ComplexFloat(8.0f, 0.0f))
            );
        }

        [Fact]
        public void ShouldAddComplexDoubleValues()
        {
            // Arrange
            ComplexDouble alpha = new(1.0f, 0.0f);
            ComplexDouble beta = new(1.0f, 0.0f);
            ComplexDouble[,] matrixA = { { new(1.0f, 0.0f), new(2.0f, 0.0f) }, { new(3.0f, 0.0f), new(4.0f, 0.0f) } };
            ComplexDouble[,] matrixB = { { new(1.0f, 0.0f), new(2.0f, 0.0f) }, { new(3.0f, 0.0f), new(4.0f, 0.0f) } };

            // Act
            var result = BLAS.Add(alpha, matrixA, beta, matrixB);

            // Assert
            result.ShouldSatisfyAllConditions(
                r => r.Rank.ShouldBe(2),
                r => r.Length.ShouldBe(4),
                r => r[0, 0].ShouldBe(new ComplexDouble(2.0f, 0.0f)),
                r => r[0, 1].ShouldBe(new ComplexDouble(4.0f, 0.0f)),
                r => r[1, 0].ShouldBe(new ComplexDouble(6.0f, 0.0f)),
                r => r[1, 1].ShouldBe(new ComplexDouble(8.0f, 0.0f))
            );
        }
    }
}