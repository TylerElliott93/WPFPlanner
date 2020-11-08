using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WPFPlanner.User_Controls;

namespace WPFPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Header { get; set; }
        public string DayLength { get; set; }

        public int DaySpanMins { get; set; }
       
        public DateTime DayStartTime { get; set; }
        public DateTime DayEndTime { get; set; }

        public ObservableCollection<TimelineItem> TimelineItems { get; set; }

        private int startHour;
        public int StartHour
        {
            get
            {
                return startHour;
            }
            set
            {
                startHour = value;
                DayStartTime = UpdateDate(startHour, StartMinute);
                OnPropertyChanged("DayStartTime");
            }
        }

        private int startMinute;
        public int StartMinute
        {
            get
            {
                return startMinute;
            }
            set
            {
                startMinute = value;
                DayStartTime = UpdateDate(startHour, startMinute);
                OnPropertyChanged("DayStartTime");
            }
        }

        private int endHour;
        public int EndHour
        {
            get
            {
                return endHour;
            }
            set
            {
                endHour = value;
                DayEndTime = UpdateDate(endHour, endMinute);


                OnPropertyChanged("DayEndTime");
            }
        }

        private int endMinute;
        public int EndMinute
        {
            get
            {
                return endMinute;
            }
            set
            {
                endMinute = value;
                DayEndTime = UpdateDate(endHour, endMinute);
                OnPropertyChanged("DayEndTime");
            }
        }

        public string Task { get; set; }

        public DateTime UpdateDate(int hour, int minute)
        {
            DayLength = (DayStartTime - DayEndTime).Hours.ToString();
            OnPropertyChanged("DayLength");
            return new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, hour, minute, 0);
        }

        public MainWindow()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;

            TimelineItems = new ObservableCollection<TimelineItem>();
            Header = $"Today is {DateTime.Today.ToString("MMMM")} {DateTime.Today.Day}";
            DayLength = "8";

            //TEST: 8hr Day Span
            DaySpanMins = 480;

            this.DataContext = this;
        }

        /// <summary>
        /// Handles pressing the RETURN key to add a new task to the timeline.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                if (TimelineItems.Count <= 15)
                {
                    var newHeight = Timeline.MaxHeight / (DaySpanMins / 60);
                    Random r = new Random();
                    int rInt = 3; //r.Next(1, 8); //for ints


                    TimelineItems.Add(new TimelineItem()
                    {
                        TaskTitle = TaskInputBox.Text,
                        TaskDuration = rInt,
                        Height = newHeight * rInt
                    });

                    OnPropertyChanged("TimelineItems");
                    TaskInputBox.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("You've planned enough for today, have a break.");
                }
                
            }
        }
    }
}
