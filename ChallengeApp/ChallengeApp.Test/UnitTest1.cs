namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScores_ShouldCollectSumAsResult()
        {
            //arrange
            var employee = new Employee("ChrisM", "Walken", 43);
            employee.AddScore(5);
            employee.AddScore(2);

            //act
            var result = employee.Result;
            
            //assert
            Assert.AreEqual(7, result);
        }

        [Test]
        public void WhenEmployeeCollectScores_ShouldCollectTotalAsResult()
        {
            //arrange
            var employee = new Employee("Monica", "Keanuen", 44);
            employee.AddScore(5);
            employee.AddScore(1);
            employee.AddScore(-2);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(4, result);
        }
    }
}