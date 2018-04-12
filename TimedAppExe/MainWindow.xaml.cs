using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimedAppExe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.Threading.DispatcherTimer dispatcherTimer { get; set; }
        private EventListMgr eventMgr { get; set; }

        public MainWindow()
        {
            eventMgr = new EventListMgr();
            eventMgr.LoadEventList();

            InitializeComponent();

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblCursorPosition.Text = dateTime.ToLocalTime().ToString();

            // Update Events Here!
            eventMgr.Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EventElement dummyElement = new EventElement { ID = 1, Name = "Dummy", StartTimeStamp = "NULL", EndTimeStamp = "NULL" };
            lv_eventList.Items.Add(dummyElement);
        }

        private void lv_eventList_Initialized(object sender, EventArgs e)
        {
            
        }

        private void lv_eventList_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            /*
            // Clicked Somewhere else
            if (lv_eventList.SelectedIndex == -1)
                return;

            ContextMenu rightClickMenu = new ContextMenu();

            rightClickMenu.Items.Add("Details");
            rightClickMenu.Items.Add("Delete");

            //lv_rightClickMenu.Show*/
        }
    }
}
