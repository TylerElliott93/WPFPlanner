using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WPFPlanner.User_Controls
{
    /// <summary>
    /// Interaction logic for TimePicker.xaml
    /// </summary>
    public partial class TimePicker : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public TimePicker()
        {
            InitializeComponent();

            PickerHour = 9;
            PickerMinute = 0;

            Meridiem = "AM";

            this.DataContext = this;
        }

        public int PickerHour
        {
            get; set;
        }

        public int PickerMinute
        {
            get; set;
        }

        public string Meridiem
        {
            get; set;
        }

        private void IncrementHour_Click(object sender, RoutedEventArgs e)
        {
            if (PickerHour == 12)
            {
                PickerHour = 1;
            }
            else
            {
                PickerHour++;
            }

            OnPropertyChanged("PickerHour");
        }

        private void DecrementHour_Click(object sender, RoutedEventArgs e)
        {
            if (PickerHour == 1)
            {
                PickerHour = 12;
            }
            else
            {

                PickerHour--;
            }
            OnPropertyChanged("PickerHour");
        }

        private void DecrementMinuteButton_Click(object sender, RoutedEventArgs e)
        {
            if (PickerMinute == 0)
            {
                PickerMinute = 50;
            }
            else
            {
                PickerMinute -= 10;
            }
            OnPropertyChanged("PickerMinute");
        }

        private void IncrementMinuteButton_Click(object sender, RoutedEventArgs e)
        {
            if (PickerMinute == 50)
            {
                PickerMinute = 0;
            }
            else
            {
                PickerMinute += 10;
            }
            OnPropertyChanged("PickerMinute");
        }

        private void AMPMToggle_Click(object sender, RoutedEventArgs e)
        {
            Meridiem = Meridiem =="AM" ? "PM" : "AM";
            OnPropertyChanged("Meridiem");
            //if (Meridiem == "AM")
            //{
            //    Meridiem = "PM";
            //}
            //else
            //{
            //    Meridiem = "AM";
            //}
        }

        //public static readonly DependencyProperty PickerHourProperty =
        //    DependencyProperty.Register("PickerHour", typeof(int), typeof(TimePicker), new PropertyMetadata(null));

        //public int PickerHour
        //{
        //    get{ return (int)GetValue(PickerHourProperty); }
        //    set{ SetValue(PickerHourProperty, value);}
        //}

        //public static readonly DependencyProperty PickerMinuteProperty =
        //    DependencyProperty.Register("PickerMinute", typeof(int), typeof(TimePicker), new PropertyMetadata(null));

        //public int PickerMinute 
        //{ 
        //    get { return (int)GetValue(PickerMinuteProperty); } 
        //    set { SetValue(PickerMinuteProperty, value); } 
        //}
    }
}
