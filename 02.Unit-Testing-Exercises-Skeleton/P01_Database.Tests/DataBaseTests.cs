using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Database.Tests
{
    public class DataBaseTests
    {
        [Test]
        [TestCase(1)]
        [TestCase(2,3,4,5,6)]
        [TestCase()]

        public void ConstructorShouldCreate16CapacityArray(params int[] initialCapacity)
        {
            var db = new Database(initialCapacity);

            Assert.That(db.Count, Is.EqualTo(initialCapacity.Length));
        }
        [Test]
        public void AddShouldThrowInvalidOperationExeptionWhenFull()
        {
            var maxCapacity = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var db = new Database(maxCapacity);

            Assert.Throws<InvalidOperationException>(()=> db.Add(17));
        }
        [Test]
        public void AddShouldAddAnElement()
        {
            var db = new Database(1,2,3,4);
            var initialLength = db.Count;
            db.Add(10);
            Assert.That(db.Count, Is.GreaterThan(initialLength));
        }
    }
}
