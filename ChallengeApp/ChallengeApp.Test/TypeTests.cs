using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void TestValueType()
        {
            //arrange
            int nr1 = 1;
            int nr2 = 2;
            float nr3 = 850.75f;
            float nr4 = 850.75f;
            decimal nr5 = 100000.5m;
            decimal nr6 = 100000m;
            string user1Name = "Chris";
            string user2Name = "Michael";
            string user3Name = "Monica";

            //act

            //assert
            Assert.AreNotEqual(nr1, nr2);
            Assert.AreEqual(nr3, nr4);
            Assert.AreNotEqual(nr5, nr6);
            Assert.AreNotSame(user1Name, user2Name);
            Assert.IsNotNull(user3Name);
        }

        [Test]
        public void TestReferenceType()
        {
            //arrange
            var user1 = GetUser("Chris", "Walken", 79);
            var user2 = GetUser("Michael", "Duncan", 54);
            var user3 = GetUser("Monica", "Cassel", 58);
            string user1Name = "Chris";
            string user2Name = "Michael";
            string user3Name = "Monica";

            //act

            //assert
            Assert.AreNotEqual(user1, user2);
            Assert.AreNotEqual(user2, user3);
            Assert.AreNotSame(user1Name, user2Name);
            Assert.IsFalse(object.ReferenceEquals(user1, user2));
            Assert.IsFalse(user1 == user2);
            Assert.IsFalse(object.Equals(user2, user3));
            Assert.IsTrue(user3Name.StartsWith("M"));
        }
        private  User GetUser(string name, string surname, int age)
        {
            return new User(name, surname, age);
        }
    }
}
