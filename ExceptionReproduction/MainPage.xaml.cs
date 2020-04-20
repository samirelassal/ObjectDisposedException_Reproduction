using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExceptionReproduction
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public static List<object> garbage = new List<object>();

        void PanGestureRecognizer_PanUpdated(System.Object sender, Xamarin.Forms.PanUpdatedEventArgs e)
        {
            lbl.GestureRecognizers.Clear();
            stk.Children.Remove(lbl);
            garbage.Add(lbl);
        }

        void btn_Clicked(System.Object sender, System.EventArgs e)
        {
            lbl.GestureRecognizers.Clear();
            stk.Children.Remove(lbl);
            garbage.Add(lbl);
        }
    }
}
