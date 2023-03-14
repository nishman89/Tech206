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
    }
}