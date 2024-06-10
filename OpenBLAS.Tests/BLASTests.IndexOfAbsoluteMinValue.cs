namespace OpenBLAS.Tests;

public static partial class BLASTests
{
    [TestOf(nameof(BLAS.IndexOfAbsoluteMinValue))]
    public sealed class IndexOfAbsoluteMinValueTests
    {
        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithPositiveValues_Float()
        {
            float[] vector = [1.0f, 3.5f, 2.0f, 4.5f, 3.0f];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithNegativeValues_Float()
        {
            float[] vector = [-1.0f, -3.5f, -2.0f, -4.5f, -3.0f];
            var incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithMixedValues_Float()
        {
            float[] vector = [1.0f, -3.5f, 2.0f, 4.5f, -3.0f];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsFirstIndex_WhenMinAbsoluteValuesAreSame_Float()
        {
            float[] vector = [3.0f, -3.0f, 2.0f, -3.0f, 3.0f];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(2);
        }

        [Fact]
        public void ReturnsIndex_WhenIncrementIsGreaterThanOne_Float()
        {
            float[] vector = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f];
            const int incX = 2;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(3);
        }

        [Fact]
        public void ThrowsArgumentException_WhenVectorIsEmpty_Float()
        {
            float[] vector = [];
            const int incX = 1;

            Assert.Throws<ArgumentException>(() => BLAS.IndexOfAbsoluteMinValue(vector, incX));
        }

        [Fact]
        public void ThrowsArgumentException_WhenIncrementIsZero_Float()
        {
            float[] vector = [1.0f, 2.0f, 3.0f, 4.0f, 5.0f];
            const int incX = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => BLAS.IndexOfAbsoluteMinValue(vector, incX));
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithPositiveValues_Double()
        {
            double[] vector = [1.0, 3.5, 2.0, 4.5, 3.0];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithNegativeValues_Double()
        {
            double[] vector = [-1.0, -3.5, -2.0, -4.5, -3.0];
            var incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithMixedValues_Double()
        {
            double[] vector = [1.0, -3.5, 2.0, 4.5, -3.0];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsFirstIndex_WhenMinAbsoluteValuesAreSame_Double()
        {
            double[] vector = [3.0, -3.0, 2.0, -3.0, 3.0];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(2);
        }

        [Fact]
        public void ReturnsIndex_WhenIncrementIsGreaterThanOne_Double()
        {
            double[] vector = [
                1.0,
                2.0,
                3.0,
                4.0,
                5.0,
                6.0
            ];
            const int incX = 2;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(3);
        }

        [Fact]
        public void ThrowsArgumentException_WhenVectorIsEmpty_Double()
        {
            double[] vector = [];
            const int incX = 1;

            Assert.Throws<ArgumentException>(() => BLAS.IndexOfAbsoluteMinValue(vector, incX));
        }

        [Fact]
        public void ThrowsArgumentException_WhenIncrementIsZero_Double()
        {
            double[] vector = [1.0, 2.0, 3.0, 4.0, 5.0];
            const int incX = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => BLAS.IndexOfAbsoluteMinValue(vector, incX));
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithPositiveValues_ComplexDouble()
        {
            ComplexDouble[] vector = [new ComplexDouble(1.0, 0), new ComplexDouble(3.5, 0), new ComplexDouble(2.0, 0), new ComplexDouble(4.5, 0), new ComplexDouble(3.0, 0)
            ];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithNegativeValues_ComplexDouble()
        {
            ComplexDouble[] vector = [new ComplexDouble(-1.0, 0), new ComplexDouble(-3.5, 0), new ComplexDouble(-2.0, 0), new ComplexDouble(-4.5, 0), new ComplexDouble(-3.0, 0)
            ];
            var incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithMixedValues_ComplexDouble()
        {
            ComplexDouble[] vector = [new ComplexDouble(1.0, 0), new ComplexDouble(-3.5, 0), new ComplexDouble(2.0, 0), new ComplexDouble(4.5, 0), new ComplexDouble(-3.0, 0)
            ];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsFirstIndex_WhenMinAbsoluteValuesAreSame_ComplexDouble()
        {
            ComplexDouble[] vector = [new ComplexDouble(3.0, 0), new ComplexDouble(-3.0, 0), new ComplexDouble(2.0, 0), new ComplexDouble(-3.0, 0), new ComplexDouble(3.0, 0)
            ];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(2);
        }

        [Fact]
        public void ReturnsIndex_WhenIncrementIsGreaterThanOne_ComplexDouble()
        {
            ComplexDouble[] vector = [
                new ComplexDouble(1.0, 0),
                new ComplexDouble(2.0, 0),
                new ComplexDouble(3.0, 0),
                new ComplexDouble(4.0, 0),
                new ComplexDouble(5.0, 0),
                new ComplexDouble(6.0, 0)
            ];
            const int incX = 2;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(5);
        }

        [Fact]
        public void ThrowsArgumentException_WhenVectorIsEmpty_ComplexDouble()
        {
            ComplexDouble[] vector = [];
            const int incX = 1;

            Assert.Throws<ArgumentException>(() => BLAS.IndexOfAbsoluteMinValue(vector, incX));
        }

        [Fact]
        public void ThrowsArgumentException_WhenIncrementIsZero_ComplexDouble()
        {
            ComplexDouble[] vector = [new ComplexDouble(1.0, 0), new ComplexDouble(2.0, 0), new ComplexDouble(3.0, 0), new ComplexDouble(4.0, 0), new ComplexDouble(5.0, 0)
            ];
            const int incX = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => BLAS.IndexOfAbsoluteMinValue(vector, incX));
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithPositiveValues_ComplexFloat()
        {
            ComplexFloat[] vector = [new ComplexFloat(1.0f, 0), new ComplexFloat(3.5f, 0), new ComplexFloat(2.0f, 0), new ComplexFloat(4.5f, 0), new ComplexFloat(3.0f, 0)
            ];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithNegativeValues_ComplexFloat()
        {
            ComplexFloat[] vector = [new ComplexFloat(-1.0f, 0), new ComplexFloat(-3.5f, 0), new ComplexFloat(-2.0f, 0), new ComplexFloat(-4.5f, 0), new ComplexFloat(-3.0f, 0)
            ];
            var incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsIndexOfMinAbsoluteValue_WithMixedValues_ComplexFloat()
        {
            ComplexFloat[] vector = [new ComplexFloat(1.0f, 0), new ComplexFloat(-3.5f, 0), new ComplexFloat(2.0f, 0), new ComplexFloat(4.5f, 0), new ComplexFloat(-3.0f, 0)
            ];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(0);
        }

        [Fact]
        public void ReturnsFirstIndex_WhenMinAbsoluteValuesAreSame_ComplexFloat()
        {
            ComplexFloat[] vector = [new ComplexFloat(3.0f, 0), new ComplexFloat(-3.0f, 0), new ComplexFloat(2.0f, 0), new ComplexFloat(-3.0f, 0), new ComplexFloat(3.0f, 0)
            ];
            const int incX = 1;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(2);
        }

        [Fact]
        public void ReturnsIndex_WhenIncrementIsGreaterThanOne_ComplexFloat()
        {
            ComplexFloat[] vector = [
                new ComplexFloat(1.0f, 0),
                new ComplexFloat(2.0f, 0),
                new ComplexFloat(3.0f, 0),
                new ComplexFloat(4.0f, 0),
                new ComplexFloat(5.0f, 0),
                new ComplexFloat(6.0f, 0)
            ];
            const int incX = 2;

            var result = BLAS.IndexOfAbsoluteMinValue(vector, incX);

            result.ShouldBe(3);
        }

        [Fact]
        public void ThrowsArgumentException_WhenVectorIsEmpty_ComplexFloat()
        {
            ComplexFloat[] vector = [];
            const int incX = 1;

            Assert.Throws<ArgumentException>(() => BLAS.IndexOfAbsoluteMinValue(vector, incX));
        }

        [Fact]
        public void ThrowsArgumentException_WhenIncrementIsZero_ComplexFloat()
        {
            ComplexFloat[] vector = [new ComplexFloat(1.0f, 0), new ComplexFloat(2.0f, 0), new ComplexFloat(3.0f, 0), new ComplexFloat(4.0f, 0), new ComplexFloat(5.0f, 0)
            ];
            const int incX = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => BLAS.IndexOfAbsoluteMinValue(vector, incX));
        }
    }
}