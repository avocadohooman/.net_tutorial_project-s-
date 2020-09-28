using System;
using Xunit;

namespace GradeBook.Test
{
    public class TypeTeest
    {

		[Fact]
		public void StringManipulation()
		{
			string name = "hello";
			name = MakeUpperCase(name);
			Assert.Equal("HELLO", name);
		}

		string MakeUpperCase(string lowCaseString)
		{
			return lowCaseString.ToUpper();
		}

		[Fact]
		public void Test1()
		{
			int x  = 3;
			x = SetInt(42);

			Assert.Equal(x, 42);
		}

		public int SetInt(int newValue)
		{
			return (newValue);
		}
		[Fact]
		public void CSharpCanPassByRef()
        {
			var book1 = GetBook("Book 1");
			GetBookSetName(ref book1, "New Name");

			Assert.Equal("New Name", book1.Name);
        }

		void GetBookSetName(ref Book book, string name)
		{
			book = new Book(name);
		}

		[Fact]
		public void CSharpIsPassByValue()
        {
			var book1 = GetBook("Book 1");
			GetBookSetName(book1, "Book3");

			Assert.Equal("Book3", book1.Name);
        }

		void GetBookSetName(Book book, string name)
		{
			book = new Book(name);
		}

		[Fact]
		public void CanSetNameFromReference()
        {
			var book1 = GetBook("Book 1");
			SetName(book1, "Book3");

			Assert.Equal("Book3", book1.Name);
        }

		void SetName(Book book, string name)
		{
			book.Name = name;
		}

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
			var book1 = GetBook("Book 1");
			var book2 = GetBook("Book 2");

			Assert.Equal("Book 1", book1.Name);
			Assert.Equal("Book 2", book2.Name);
        }

		[Fact]
		public void TwoVariablesCanReferenceSameObject()
        {
			var book1 = GetBook("Book 1");
			var book2 = book1.Name;

			Assert.Same(book1, book2);
        }

		Book GetBook(string name)
		{
			return new Book(name);
		}
    }
}
