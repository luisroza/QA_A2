namespace A2.TriangleSolver
{
    public class Triangle
    {
        public string AnalyzeTriangle(int firstSide, int secondSide, int thirdSide)
        {
            if (firstSide == 0 || secondSide == 0 || thirdSide == 0)
            {
                return "At least one side of your triangle has a zero length and is thus invalid";
            }

            if ((firstSide + secondSide) > thirdSide && (firstSide + thirdSide) > secondSide && (secondSide + thirdSide) > firstSide)
            {
                if (firstSide == secondSide && firstSide == thirdSide && secondSide == thirdSide)
                {
                    return "Based on all sides being equal, the type of triangle is an EQUILATERAL";
                }
                else if (firstSide == secondSide || secondSide == thirdSide || thirdSide == firstSide)
                {
                    return "Based on two sides being equal, the type of triangle is an ISOSCELES";
                }
                else
                {
                    return "Based on all three sides being different, the type of triangle is a SCALENE";
                }
            }

            return "Based on the values entered, the triangle is INVALID";
        }
    }
}
