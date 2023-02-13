namespace A2.Test
{
    public class Tests
    {
        private const string EQUILATERAL_TRIANGLE = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
        private const string ISOSCELES_TRIANGLE = "Based on two sides being equal, the type of triangle is an ISOSCELES";
        private const string SCALENE_TRIANGLE = "Based on all three sides being different, the type of triangle is a SCALENE";
        private const string INVALID_TRIANGLE = "Based on the values entered, the triangle is INVALID";
        private const string INVALID_INPUT = "At least one side of your triangle has a zero length and is thus invalid";

        //Only one(1) test for a valid equilateral triangle
        [Test]
        public void ValidEquilateralTriangle_SingleValue_ReturnsValidTriangle()
        {
            // Arrange
            const int angle1 = 45;
            const int angle2 = 45;
            const int angle3 = 45;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(EQUILATERAL_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(EQUILATERAL_TRIANGLE));
        }

        //Three(3) tests for a valid isosceles triangle
        [Test]
        public void ValidIsoscelesTriangle_FirstAndSecondSidesEquals_ReturnsValidTriangle()
        {
            // Arrange
            const int angle1 = 45;
            const int angle2 = 45;
            const int angle3 = 60;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(ISOSCELES_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(ISOSCELES_TRIANGLE));
        }

        [Test]
        public void ValidIsoscelesTriangle_SecondAndThirdSidesEquals_ReturnsValidTriangle()
        {
            // Arrange
            const int angle1 = 45;
            const int angle2 = 60;
            const int angle3 = 60;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(ISOSCELES_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(ISOSCELES_TRIANGLE));
        }

        [Test]
        public void ValidIsoscelesTriangle_FirstAndThirdSidesEquals_ReturnsValidTriangle()
        {
            // Arrange
            const int angle1 = 45;
            const int angle2 = 60;
            const int angle3 = 45;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(ISOSCELES_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(ISOSCELES_TRIANGLE));
        }

        //Five(5) tests for a valid scalene triangle
        [Test]
        public void ValidScaleneTriangle_FirstSideHighestThirdSideLowest_ReturnsValidTriangle()
        {
            // Arrange
            const int angle1 = 60;
            const int angle2 = 45;
            const int angle3 = 30;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(SCALENE_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(SCALENE_TRIANGLE));
        }

        [Test]
        public void ValidScaleneTriangle_SecondSideHighestThirdSideLowest_ReturnsValidTriangle()
        {
            // Arrange
            const int angle1 = 45;
            const int angle2 = 60;
            const int angle3 = 30;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(SCALENE_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(SCALENE_TRIANGLE));
        }

        [Test]
        public void ValidScaleneTriangle_ThirdSideHighestFirsSideLowest_ReturnsValidTriangle()
        {
            // Arrange
            const int angle1 = 30;
            const int angle2 = 45;
            const int angle3 = 60;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(SCALENE_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(SCALENE_TRIANGLE));
        }

        [Test]
        public void ValidScaleneTriangle_FirstSideHighestSecondSideLowest_ReturnsValidTriangle()
        {
            // Arrange
            const int angle1 = 60;
            const int angle2 = 30;
            const int angle3 = 45;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(SCALENE_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(SCALENE_TRIANGLE));
        }

        [Test]
        public void ValidScaleneTriangle_ThirdSideHighestSecondSideLowest_ReturnsValidTriangle()
        {
            // Arrange
            const int angle1 = 45;
            const int angle2 = 30;
            const int angle3 = 60;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(SCALENE_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(SCALENE_TRIANGLE));
        }

        //Three(3) tests for verifying a zero length for one or more sides
        [Test]
        public void InvalidAngleInput_FirstSideZero_ReturnsInvalidInputMessage()
        {
            // Arrange
            const int angle1 = 0;
            const int angle2 = 15;
            const int angle3 = 30;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(INVALID_INPUT, actual);
            Assert.That(actual, Is.EqualTo(INVALID_INPUT));
        }

        [Test]
        public void InvalidAngleInput_SecondSideZero_ReturnsInvalidInputMessage()
        {
            // Arrange
            const int angle1 = 15;
            const int angle2 = 0;
            const int angle3 = 30;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(INVALID_INPUT, actual);
            Assert.That(actual, Is.EqualTo(INVALID_INPUT));
        }

        [Test]
        public void InvalidAngleInput_ThirdSideZero_ReturnsInvalidInputMessage()
        {
            // Arrange
            const int angle1 = 30;
            const int angle2 = 15;
            const int angle3 = 0;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(INVALID_INPUT, actual);
            Assert.That(actual, Is.EqualTo(INVALID_INPUT));
        }

        //if ((firstSide + secondSide) > thirdSide && (firstSide + thirdSide) > secondSide && (secondSide + thirdSide) > firstSide)

        //Three(3) tests for verifying an invalid response(other than a zero length)
        [Test]
        public void InvalidTriangle_SumFirstAndSecondSidesNotGreaterThanThirdSide_ReturnsInvalidTriangle()
        {
            // Arrange
            const int angle1 = 10;
            const int angle2 = 15;
            const int angle3 = 50;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(INVALID_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(INVALID_TRIANGLE));
        }

        [Test]
        public void InvalidTriangle_SumFirstAndThirdSidesNotGreaterThanSecondSide_ReturnsInvalidTriangle()
        {
            // Arrange
            const int angle1 = 10;
            const int angle2 = 50;
            const int angle3 = 15;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(INVALID_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(INVALID_TRIANGLE));
        }

        [Test]
        public void InvalidTriangle_SumSecondAndThirdSidesNotGreaterThanFirstSide_ReturnsInvalidTriangle()
        {
            // Arrange
            const int angle1 = 50;
            const int angle2 = 10;
            const int angle3 = 15;

            // Act
            var triangleAnalyzer = new Triangle();
            var actual = triangleAnalyzer.AnalyzeTriangle(angle1, angle2, angle3);

            // Assert
            //Assert.AreEqual(INVALID_TRIANGLE, actual);
            Assert.That(actual, Is.EqualTo(INVALID_TRIANGLE));
        }
    }
}