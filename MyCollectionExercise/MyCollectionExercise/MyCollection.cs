using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionExercise
{
    public class MyCollection
    {
        private T[] internalArray;

        public MyCollection()
        {
            this.internalArray = new T[4];

        }

        public T Value { get; set; } = default(T);
        
    }
}
