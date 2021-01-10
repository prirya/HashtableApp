using System;
using System.Collections;
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

namespace HashtableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addBottom_Click(object sender, RoutedEventArgs e)
        {
            //Add
            hashtable.Add(keytxtbox.Text, valuetxtbox.Text);
            keytxtbox.Text = "";
            valuetxtbox.Text = "";
        }

        private void removeBottom_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            hashtable.Remove(keytxtbox.Text);
            keytxtbox.Text = "";
            valuetxtbox.Text = "";
        }

        private void showAllBottom_Click(object sender, RoutedEventArgs e)
        {
            //Show All
            ICollection Icollection = hashtable.Keys;
            foreach (string key in Icollection) 
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
