using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPlanner.User_Controls
{
    /// <summary>
    /// Interaction logic for TimePicker.xaml
    /// </summary>
    public partial class TimePicker : UserControl
    {
        public TimePicker()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty PickerHourProperty =
            DependencyProperty.Register("PickerHour", typeof(int), typeof(TimePicker), new PropertyMetadata(null));
        
        public int PickerHour
        {
            get{ return (int)GetValue(PickerHourProperty); }
            set{ SetValue(PickerHourProperty, value);}
        }

        public static readonly DependencyProperty PickerMinuteProperty =
            DependencyProperty.Register("PickerMinute", typeof(int), typeof(TimePicker), new PropertyMetadata(null));

        public int PickerMinute 
        { 
            get { return (int)GetValue(PickerMinuteProperty); } 
            set { SetValue(PickerMinuteProperty, value); } 
        }
    }
}
