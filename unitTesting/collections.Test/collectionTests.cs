using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.Test
{
    [TestFixture]
    public class collectionTests
    {
        [Test]
        public void CollectionShouldBe16ForEmptyCollection()
        {
            //Arange,Act
            var collection = new Collection<int>();
            //Asert
            Assert.That(collection.Count, Is.EqualTo(16));
        }
        
        [Test]
        public void CollectionShouldBeEqualToCollectionInitialSize()
        {
            var collection = new Collection<int>(1,2,3);

            Assert.That(collection.Count(), Is.EqualTo(3));
        }
    }
}
