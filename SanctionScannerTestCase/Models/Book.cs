using System;
namespace SanctionScannerTestCase.Models
{
	public class Book
	{

		public string Name { get; set; }
        public string Author { get; set; }
        public string Cover  { get; set; }
		public bool IsBookInLibrary { get; set; }


        public Book()
		{
		}

        public Book(string name, string author)
        {
        }

        public Book(string name, string author, string cover, bool isBookInLibrary)
        {

        }

    }
}

