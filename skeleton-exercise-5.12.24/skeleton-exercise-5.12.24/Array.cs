using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skeleton_exercise_5._12._24
{
    public class Array
    {
        private int[] items;
        private int count;

        public Array(int capacity = 8) 
        {
            items = new int[capacity];
            count = 0;
        }
        public int Count => count;

        public void Add(int item)
        {
            if (count == items.Length) 
            {
                Resize();
            }
            items[count++] = item;
        }

        private void Resize() 
        {
            int[] newArray = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++) 
            {
             newArray[i] = items[i];    
            }
            items = newArray;
        }

        public int CountFreePositions()
        {
            int freePositions = items.Length - count;
            return freePositions;
        }

        public void Cut(int cutCount)
        {
            if (cutCount > count)
            {
                throw new ArgumentException("Number is out of range.");
            }

            for (int i = cutCount; i < count; i++)
            {
                items[i - cutCount] = items[i];

            }

           count -= cutCount;

            for(int i =count; i < items.Length; i++)
            {
                items[i] = 0;
            }
        }

        public int Change(int element, int newElement)
        {
            for (int i = 0; i < count; i++) 
            {
              if(items[i] == element)
                {
                    items[i] = newElement;
                    return i;
                }
              
            }
            return -1;  

        }
    }
}
