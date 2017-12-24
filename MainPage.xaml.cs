using System;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ListView
{
	public partial class MainPage : ContentPage
	{
		public class Book
		{
			public string Title { get; set; }
			public string Author { get; set; }
		}

		public static ObservableCollection<Book> Books;
		
		public MainPage()
		{
			InitializeComponent();

			Books = new ObservableCollection<Book>()
			{
				new Book(){Title="Killing Floor", Author="Lee Child" },
				new Book(){Title="Man On Fire", Author="A.J.Quinnell" },
				new Book(){Title="The Lion's Game", Author="Neldon Demille"}
			};
			BookListView.ItemsSource = Books;
		}

		/* Insert the new book to the book list */
		void AddNewBook(object sender, EventArgs e)
		{
			Book new_book;
			new_book = new Book() { Title = Entry_Title.Text, Author = Entry_Author.Text };

			Books.Insert(0, new_book);
		}

		/* Move the Book Information page "BookInfo" when one of the books was tapped, 
		   and send the tapped book information to the page */
		async void OnTap(object sender, ItemTappedEventArgs e)
		{
			//Any codes as below, No.1 to 3, is OK to get e.Item as Book class
			/* No.1 */ Book TappedBookClass = (Book)e.Item;
			/* No.2 object o = (object)e.Item;
			        Book TappedBookClass = (Book)o; */
			/* No.3 var TappedBookClass = e.Item as Book; */

			//Send the tapped book information to BookInfo page
			string[] TappedBookString=
				{TappedBookClass.Title, TappedBookClass.Author};
			await Navigation.PushAsync(new BookInfo(TappedBookString));
		}
	}
}
