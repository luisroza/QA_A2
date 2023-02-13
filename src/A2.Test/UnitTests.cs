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
    }
}