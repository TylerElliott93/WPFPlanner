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
    /// Interaction logic for TimelineItem.xaml
    /// </summary>
    public partial class TimelineItem : UserControl
    {
        public string TaskTitle { get; set; }

        public int TaskDuration { get; set; }

        public TimelineItem()
        {
            InitializeComponent();

            //Default duration of 2hr
            TaskDuration = 2;

            this.DataContext = this;
        }
    }
}
