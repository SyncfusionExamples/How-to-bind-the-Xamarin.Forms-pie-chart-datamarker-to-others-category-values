using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseView : ContentPage
    {
        public BaseView()
        {
            InitializeComponent();
        }

        private void SfCheckBox_StateChanged(object sender, Syncfusion.XForms.Buttons.StateChangedEventArgs e)
        {
            if (e.IsChecked == true)
            {
                sfBorder.Content = new SumOfValue();
            }
            else
            {
                sfBorder.Content = new CategoriesInOthers();
            }
        }
    }
}