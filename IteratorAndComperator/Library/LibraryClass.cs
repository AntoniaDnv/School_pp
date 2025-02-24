using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace Library
{
    
    
        public class LibraryClass : IEnumerable<Book>
        {
            private List<Book> books;

            public LibraryClass(params Book[] books)
            {
                this.books = new List<Book>(books);
            }

            public IEnumerator<Book> GetEnumerator()
            {
                foreach (var book in books)
                {
                    yield return book; 
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    
}
