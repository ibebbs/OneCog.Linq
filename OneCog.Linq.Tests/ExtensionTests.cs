using NUnit.Framework;
using System.Collections.Generic;

namespace OneCog.Linq.Tests
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void ShouldPerformActionForEachItem()
        {
            List<string> expected = new List<string>(new[] { "Ian", "Mikee", "Dave" });
            List<string> actual = new List<string>();

            expected.ForEach(actual.Add);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
