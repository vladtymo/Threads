using System;
using System.IO;
using System.Threading;
using System.Windows;

namespace WpfApp_task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Operation1()
        {
            for (int i = 0; i < 10; i++)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    lb1.Items.Add($"Element: {i + 1}");
                });
                Thread.Sleep(rnd.Next(250));
            }
        }
        private void Operation2()
        {
            for (int i = 0; i < 10; i++)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    lb2.Items.Add($"Element: {i + 1}");
                });
                Thread.Sleep(rnd.Next(250));
            }
        }
        private void Operation3()
        {
            for (int i = 0; i < 10; i++)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    lb3.Items.Add($"Element: {i + 1}");
                });
                Thread.Sleep(rnd.Next(250));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Operation1();
            //Operation2();
            //Operation3();

            Thread[] threads =
            {
                new Thread(Operation1),
                new Thread(Operation2),
                new Thread(Operation3),
            };

            foreach (var t in threads)
                t.Start();
        }
    }
}