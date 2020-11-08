using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;

namespace WPFPlanner.User_Controls
{
    /// <summary>
    /// Interaction logic for TimelineItem.xaml
    /// </summary>
    public partial class TimelineItem : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string TaskTitle { get; set; }

        public int TaskDurationMins { get; set; }

        public string TotalDuration
        {
            get
            {
                TimeSpan ts = TimeSpan.FromMinutes(TaskDurationMins);
                return string.Format("{0}:{1}", ts.Hours, ts.Minutes);
            }
            set 
            { 
                //EMPTY
            }
        }

        public Color TimelineItemColor
        {
            get; set;
        }

        public TimelineItem()
        {
            InitializeComponent();

            //Default is 1hr
            TaskDurationMins = 60;
            TimelineItemColor = Color.Green;

            this.DataContext = this;
        }

        private void ButtonHourDecrement_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AllocatedMins -= 60;
            if(TaskDurationMins != 0)
            {
                TaskDurationMins -= 60;
            }
            OnPropertyChanged("TaskDurationHrs");
        }

        private void ButtonHourIncrement_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AllocatedMins += 60;
            if(MainWindow.AllocatedMins < MainWindow.DaySpanMins)
            {
                TaskDurationMins+=60;
                OnPropertyChanged("TotalDuration");
            }
            else
            {
                MessageBox.Show("Total Task Time Exceeds Day Length");
            }
        }

        private void ButtonMinuteDecrement_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AllocatedMins -= 10;
        }

        private void ButtonMinuteIncrement_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AllocatedMins -= this.TaskDurationMins;
            MainWindow.TimelineItems.Remove(this);
        }
    }
}
