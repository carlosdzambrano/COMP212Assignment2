using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace Assignment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<MenuItem> beverages = new List<MenuItem>();
        List<MenuItem> starters = new List<MenuItem>();
        List<MenuItem> main = new List<MenuItem>();
        List<MenuItem> desserts = new List<MenuItem>();

        ObservableCollection<MenuItem> order = new ObservableCollection<MenuItem>();
        double subtotal = 0;

        public MainWindow()
        {
            InitializeComponent();

            beverages.Add(new MenuItem(""));
            beverages.Add(new MenuItem("Soda", 1.95, 1));
            beverages.Add(new MenuItem("Tea", 1.50, 1));
            beverages.Add(new MenuItem("Coffee", 1.25, 1));
            beverages.Add(new MenuItem("Mineral Water", 2.95, 1));
            beverages.Add(new MenuItem("Juice", 2.50, 1));
            beverages.Add(new MenuItem("Milk", 1.50, 1));
            beverageCombo.ItemsSource = beverages;

            starters.Add(new MenuItem(""));
            starters.Add(new MenuItem("Buffalo Wings", 5.95, 1));
            starters.Add(new MenuItem("Buffalo Fingers", 6.95, 1));
            starters.Add(new MenuItem("Potato Skins", 8.95, 1));
            starters.Add(new MenuItem("Nachos", 8.95, 1));
            starters.Add(new MenuItem("Mushroom Caps", 10.95, 1));
            starters.Add(new MenuItem("Shrimp Cocktail", 12.95, 1));
            starters.Add(new MenuItem("Chips and Salsa", 6.95, 1));
            starterCombo.ItemsSource = starters;

            main.Add(new MenuItem(""));
            main.Add(new MenuItem("Seafood Alfredo", 15.95, 1));
            main.Add(new MenuItem("Chicken Alfredo", 13.95, 1));
            main.Add(new MenuItem("Chicken Picatta", 13.95, 1));
            main.Add(new MenuItem("Turkey Club", 11.95, 1));
            main.Add(new MenuItem("Lobster Pie", 19.95, 1));
            main.Add(new MenuItem("Prime Rib", 20.95, 1));
            main.Add(new MenuItem("Shrimp Scapi", 18.95, 1));
            main.Add(new MenuItem("Turkey Dinner", 13.95, 1));
            main.Add(new MenuItem("Stuffed Chicken", 14.95, 1));
            mainCombo.ItemsSource = main;

            desserts.Add(new MenuItem(""));
            desserts.Add(new MenuItem("Apple Pie", 5.95, 1));
            desserts.Add(new MenuItem("Sundae", 3.95, 1));
            desserts.Add(new MenuItem("Carrot Cake", 5.95, 1));
            desserts.Add(new MenuItem("Mud Pie", 4.95, 1));
            desserts.Add(new MenuItem("Apple Crisp", 5.95, 1));
            dessertCombo.ItemsSource = desserts;

            //orderDg.ItemsSource = desserts;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (starterCombo.SelectedIndex > 0)
            {
                //orderDg.Items.Add(starterCombo.SelectedItem);
                MenuItem mi = (MenuItem)starterCombo.SelectedItem;
                order.Add(mi);

                subtotal += mi.Price * mi.Quantity;
                starterCombo.SelectedIndex = 0;
            }
            if (beverageCombo.SelectedIndex > 0)
            {
                //orderDg.Items.Add(beverageCombo.SelectedItem);
                MenuItem mi = (MenuItem)beverageCombo.SelectedItem;
                order.Add(mi);

                subtotal += mi.Price * mi.Quantity;
                beverageCombo.SelectedIndex = 0;
            }
            if (mainCombo.SelectedIndex > 0)
            {
                //orderDg.Items.Add(mainCombo.SelectedItem);
                MenuItem mi = (MenuItem)mainCombo.SelectedItem;
                order.Add(mi);

                subtotal += mi.Price * mi.Quantity;
                mainCombo.SelectedIndex = 0;
            }
            if (dessertCombo.SelectedIndex > 0)
            {
                //orderDg.Items.Add(dessertCombo.SelectedItem);
                MenuItem mi = (MenuItem)dessertCombo.SelectedItem;
                order.Add(mi);

                subtotal += mi.Price * mi.Quantity;
                dessertCombo.SelectedIndex = 0;
            }

            subTxtB.Text = "$" + Convert.ToString(subtotal);
            taxTB.Text = "$" + Convert.ToString(Math.Round(subtotal * 0.13,2));
            totalTxtB.Text = "$" + Convert.ToString(Math.Round(subtotal * 1.13, 2));

            orderDg.ItemsSource = order;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

            order.Clear();
            subtotal = 0;
            subTxtB.Text = "";
            taxTB.Text = "";
            totalTxtB.Text = "";
        }

        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "centennialcollege.ca");
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (orderDg.SelectedIndex >= 0)
            {
                MenuItem mi = (MenuItem)orderDg.SelectedItem;
                subtotal -= mi.Price;

                subTxtB.Text = "$" + Convert.ToString(subtotal);
                taxTB.Text = "$" + Convert.ToString(Math.Round(subtotal * 0.13, 2));
                totalTxtB.Text = "$" + Convert.ToString(Math.Round(subtotal * 1.13, 2));

                order.RemoveAt(orderDg.SelectedIndex);
            }
        }

        private void orderDg_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            MenuItem mi = (MenuItem)orderDg.SelectedItem;
            subtotal += mi.Price * mi.Quantity;


            //if (subtotal < 0)
            //{
            //    subtotal = 0;
            //}
            subTxtB.Text = "$" + Convert.ToString(subtotal);
            taxTB.Text = "$" + Convert.ToString(Math.Round(subtotal * 0.13, 2));
            totalTxtB.Text = "$" + Convert.ToString(Math.Round(subtotal * 1.13, 2)); 
        }

        private void orderDg_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            MenuItem mi = (MenuItem)orderDg.SelectedItem;

            subtotal -= mi.Price * mi.Quantity;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
