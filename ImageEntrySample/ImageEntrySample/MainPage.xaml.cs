using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageEntrySample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Xamarin.Forms.ImageEntry.ImageEntry teste = new Xamarin.Forms.ImageEntry.ImageEntry();
        }
    }
}
