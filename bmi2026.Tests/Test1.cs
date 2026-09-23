using BMICalculator;

namespace bmi2026.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void BMIValue_AdditionalPounds_IncreasesBMI()
        {
            BMI withoutPounds = new BMI
            {
                WeightStones = 10,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 8
            };

            BMI withPounds = new BMI
            {
                WeightStones = 10,
                WeightPounds = 10,
                HeightFeet = 5,
                HeightInches = 8
            };

            double bmiWithoutPounds = withoutPounds.BMIValue;
            double bmiWithPounds = withPounds.BMIValue;

           
            Assert.IsGreaterThan(bmiWithoutPounds, bmiWithPounds);
        }

        [TestMethod]
        public void BMICategory_NormalBMI_ReturnsNormal()
        {
            BMI bmi = new BMI
            {
                WeightStones = 10,
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 8
            };

 
            BMICategory result = bmi.BMICategory;


            Assert.AreEqual(BMICategory.Normal, result);
        }
    }
}
