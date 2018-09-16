using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingAppX.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Hack : ContentPage
	{
		public Hack ()
		{
			InitializeComponent ();

            GetDefault();
		}

        private void GetDefault()
        {

            //Label label = new Label();
            //label.Text = "http://www.google.com/";

            //var tapGestureRecognizer = new TapGestureRecognizer();
            //tapGestureRecognizer.Tapped += (s, e) => {
            //    Device.OpenUri(new Uri(((Label)s).Text));
            //};
            //label.GestureRecognizers.Add(tapGestureRecognizer);

            //Content = label;

        }
    }
}