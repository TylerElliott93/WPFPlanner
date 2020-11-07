using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WPFPlanner.User_Controls;

namespace WPFPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Properties
        public string Header { get; set; }

        public static DateTime DayStartTime { get; set; }
        public static DateTime DayEndTime { get; set; }

        public List<TimelineItem> TimelineItems { get; set; }

        public int StartHour { get; set; }
        public int StartMinute { get; set; }

        public int EndHour { get; set; }
        public int EndMinute { get; set; }

        public string Task { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Header = $"Today is {DateTime.Today.ToString("MMMM")} {DateTime.Today.Day}";
            TimelineItems = new List<TimelineItem>();

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
                if (TimelineItemsControl.Items.Count <= 15)
                {
                    TimelineItemsControl.Items.Add(new TimelineItem()
                    {
                        TaskTitle = TaskInputBox.Text
                    }
                    );
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
