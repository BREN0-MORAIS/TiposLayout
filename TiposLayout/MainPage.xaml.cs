using System;
using TiposLayout.Grid;
using TiposLayout.Relative;
using TiposLayout.Scroll;
using TiposLayout.Stack;
using Xamarin.Forms;

namespace TiposLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoPaginaStack(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new StackPage());
        }
        private void GoPaginaGrid(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new GridPage());
        }
        private void GoPaginaAbsolute(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new AbsolutePage());
        }
        private void GoPaginaRelative(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new RelativePage());
        }
        private void GoPaginaScroll(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new ScrollPage());
        }


    }
}
