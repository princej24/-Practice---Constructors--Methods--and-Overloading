using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Account account = new Account("2293", "prince Muturi", 20.00m);
            MessageBox.Show(account.ToString()); 

            account.Deposit( 500.00m);
            MessageBox.Show(account.ToString()); 

            account.Deposit(- 15000.00m);
            MessageBox.Show(account.ToString()); 

            account.Withdraw(300.00m);
            MessageBox.Show(account.ToString());

            account.Withdraw(-500.00m);
            MessageBox.Show(account.ToString()); 

            MessageBox.Show(account.ToString());


            
                Car Car = new Car(); 

                Car makeModelCar = new Car("Toyota", "Rav4");
                Car fullCar = new Car("Hyundai", "Sonata", 2010, 100000);

                MessageBox.Show(Car.ToString());
                MessageBox.Show(makeModelCar.ToString());
                MessageBox.Show(fullCar.ToString());
            
        }
    }
}
