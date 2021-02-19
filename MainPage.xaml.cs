using Syncfusion.SfRangeSlider.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RangeSlider
{   /// <summary>
    /// Observable collection of Items list.
    /// </summary>
    public class ObservableCollectionList : ObservableCollection<Items>
    {

    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
