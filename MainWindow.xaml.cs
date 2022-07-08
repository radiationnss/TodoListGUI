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

namespace TodoListGUIfinal
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

        private void Add_ToList(object sender, RoutedEventArgs e)
        {
            TodoListStuff.Items.Insert(TodoListStuff.Items.Count, tbTodo.Text);
            tbTodo.Clear();
        }
        private void Remove_From_List(object sender, RoutedEventArgs e)
        {
            int index = TodoListStuff.SelectedIndex;
            TodoListStuff.Items.RemoveAt(index);
            tbTodo.Clear();
        }
        private void Clear_List(object sender, RoutedEventArgs e)
        {
            TodoListStuff.Items.Clear();
        }
    }
}
