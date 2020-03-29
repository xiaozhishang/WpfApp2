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

using System.ComponentModel;
using System.Threading;
//using System.Windows;
using System.Windows.Threading;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //声明一个计时器
        private DispatcherTimer showtimer;

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            showtimer = new DispatcherTimer();//实例化计时器
            showtimer.Tick += new EventHandler(time);
            showtimer.Interval = new TimeSpan(0, 0, 0, 1, 0);//控制时间在一秒跳动一次
            showtimer.Start();//开启时间

        }

        /// <summary>
        /// 绑定数据的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time(object sender, EventArgs e)
        {
            //获取本地时间并转换为年-月-日 /时 分 秒格式
            //yyyy - MM - dd / HH mm ss   年-月-日 /时 分 秒
            textBox.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff");
        }
    }
}
