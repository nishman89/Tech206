using NUnit.Framework;
using OperatorsApp;

namespace OperatorsControlFlowTests
{
    public class StoneTests
    {
        [TestCase(156, 11)]
        [TestCase(140, 10)]
        [TestCase(8, 0)]
        [TestCase(0, 0)]
        public void GivenANumberOfPounds_GetStones_ReturnTheCorrectNumberOfStones(int pounds, int expStones)
        {
            var result = Method.GetStones(pounds);
            Assert.That(result, Is.EqualTo(expStones));
        }

        [TestCase(156, 2)]
        [TestCase(140, 0)]
        [TestCase(8, 8)]
        [TestCase(0, 0)]
        public void GivenANumberOfPounds_GetPounds_ReturnTheCorrectNumberOfPounds(int pounds, int expPounds)
        {
            var result = Method.GetPounds(pounds);
            Assert.That(result, Is.EqualTo(expPounds));
        }

        [Test]
        public void GivenANegativeNumberOfPounds_GetPounds_ThrowsException()
        {
            Assert.That(() => Method.GetPounds(-1), Throws.ArgumentException.With.Message.Contain("No negative values"));
        }

        [Test]
        public void GivenANegativeNumberOfPounds_GetStones_ThrowsException()
        {
            Assert.That(() => Method.GetStones(-1), Throws.ArgumentException.With.Message.Contain("No negative values"));

        }
    }
}