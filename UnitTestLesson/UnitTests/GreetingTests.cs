using CodeToTest;

namespace UnitTests
{
    public class GreetingTests
    {


        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            // Arrange - Given
            var time = 21;
            var expectedGreeting = "Good evening!";
            // Act - When
            var result = Program.Greeting(time);
            // Assert - Then
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }


        [Test]
        public void GivenATimeOf15_Greeting_ReturnsGoodAfternoon()
        {
            Assert.That(Program.Greeting(15), Is.EqualTo("Good afternoon!"));
        }

        //[Ignore("Supposed to fail")]
        [Category("FailTest")]
        [Test]
        public void ThisTestIsSupposedToFail()
        {
            //Assert.That(Program.Greeting(2), Is.EqualTo("Good evening!"));
            Assert.Fail();
        }

        [TestCase(5)]
        [TestCase(11)]
        [TestCase(8)]
        public void GivenATimeLessThan12_MoreThan5_Greeting_ReturnsGoodMorning(int timeOfDay)
        {
            Assert.That(Program.Greeting(timeOfDay), Is.EqualTo("Good morning!"));
        }


        [TestCase(11, "Good morning!")]
        [TestCase(13, "Good afternoon!")]
        [TestCase(18, "Good afternoon!")]
        [TestCase(19, "Good evening!")]
        public void GivenANumber_Greeting_ReturnsCorrectGreeting(int time, string expected)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo(expected));
        }
    }
}