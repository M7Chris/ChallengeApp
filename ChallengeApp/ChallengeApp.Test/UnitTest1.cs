namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectScores_ShouldCollectSumAsResult()
        {
            //arrange
            var user = new User("ChrisM", "Walken", 79);
            user.AddScore(5);
            user.AddScore(2);

            //act
            var  result = user.Result;
            
            //assert
            Assert.AreEqual(7, result);
        }

        [Test]
        public void WhenUserCollectScores_ShouldCollectTotalAsResult()
        {
            //arrange
            var user = new User("Monica", "Keanuen", 58);
            user.AddScore(5);
            user.AddScore(1);
            user.AddScore(-2);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(4, result);
        }
    }
}