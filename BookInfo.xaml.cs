//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

namespace ListView
{
	public partial class BookInfo : ContentPage
	{
		/* Book Information Page
		      showing the tapped book title & author */
		public BookInfo (string[] TappedBookString)
		{
			InitializeComponent ();
			TappedBookTitle.Text = TappedBookString[0];
			TappedBookAuthor.Text = TappedBookString[1];
		}
	}
}