using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MOD1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyTheme : ResourceDictionary
	{
		public MyTheme ()
		{
			InitializeComponent ();
		}
	}
}