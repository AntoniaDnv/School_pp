using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper
{
    public class News
    {
        private string title;
        private string text;
        private string writer;

        public News(string title, string text, string writer) 
        {
            Title = title;
            Text = text;
            Writer = writer;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public string Writer
        {
            get { return writer; }
            set { writer = value; }
        }
        public void Edit( string newText)
        {
            Text = newText;
        }

        public void ChangeWriter(string newWriter) 
        {
          Writer = newWriter;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Text}: {Writer}";
        }
    }
}
