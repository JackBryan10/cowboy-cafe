/* Author: Jack Walter
 * Class Name: CashRegisterControl.cs
 * Purpose: Interaction logic for CashRegisterControl.xaml
*/
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        private TransactionControl transaction;

        /// <summary>
        /// Constructor for the CashRegisterControl User Control
        /// </summary>
        public CashRegisterControl(object Transaction)
        {
            transaction = (TransactionControl)Transaction;
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler for when Bills are paid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BillButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (DataContext is CashRegisterModelView data)
                {
                    switch (button.Name)
                    {
                        case "Ones":
                            data.RunningTotal -= 1.00;
                            data.BillsAdded.Add(Bills.One);
                            break;
                        case "Fives":
                            data.RunningTotal -= 5.00;
                            data.BillsAdded.Add(Bills.Five);
                            break;
                        case "Tens":
                            data.RunningTotal -= 10.00;
                            data.BillsAdded.Add(Bills.Ten);
                            break;
                        case "Twenties":
                            data.RunningTotal -= 20.00;
                            data.BillsAdded.Add(Bills.Twenty);
                            break;
                        case "Fifties":
                            data.RunningTotal -= 50.00;
                            data.BillsAdded.Add(Bills.Fifty);
                            break;
                        case "Hundreds":
                            data.RunningTotal -= 100.00;
                            data.BillsAdded.Add(Bills.Hundred);
                            break;
                    }
                    if (data.RunningTotal < 0.009 || data.RunningTotal == 0) { OpenDrawerButton.IsEnabled = true; }
                }
            }
        }

        /// <summary>
        /// Event Handler for when Coins are paid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CoinButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (DataContext is CashRegisterModelView data)
                {
                    switch (button.Name)
                    {
                        case "Pennies":
                            data.RunningTotal -= 0.01;
                            data.CoinsAdded.Add(Coins.Penny);
                            break;
                        case "Nickels":
                            data.RunningTotal -= 0.05;
                            data.CoinsAdded.Add(Coins.Nickel);
                            break;
                        case "Dimes":
                            data.RunningTotal -= 0.10;
                            data.CoinsAdded.Add(Coins.Nickel);
                            break;
                        case "Quarters":
                            data.RunningTotal -= 0.25;
                            data.CoinsAdded.Add(Coins.Quarter);
                            break;
                    }
                    if (data.RunningTotal < 0.009 || data.RunningTotal == 0) { OpenDrawerButton.IsEnabled = true; }
                }
            }
        }

        /// <summary>
        /// Event Handler for when the Cash Register Drawer is opened and bills and coins are added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenDrawer_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashRegisterModelView data)
            {
                if (sender is Button button)
                {
                    foreach (Bills bill in data.BillsAdded)
                    {
                        switch (bill)
                        {
                            case Bills.One:
                                data.Ones++;
                                break;
                            case Bills.Five:
                                data.Fives++;
                                break;
                            case Bills.Ten:
                                data.Tens++;
                                break;
                            case Bills.Twenty:
                                data.Twenties++;
                                break;
                            case Bills.Fifty:
                                data.Fifties++;
                                break;
                            case Bills.Hundred:
                                data.Hundreds++;
                                break;
                        }
                    }
                    foreach (Coins coin in data.CoinsAdded)
                    {
                        switch (coin)
                        {
                            case Coins.Penny:
                                data.Pennies++;
                                break;
                            case Coins.Nickel:
                                data.Nickels++;
                                break;
                            case Coins.Dime:
                                data.Dimes++;
                                break;
                            case Coins.Quarter:
                                data.Quarters++;
                                break;
                        }
                    }
                    string changeString = ChangeMessage(CalculateChange());
                    MessageBox.Show(changeString, String.Format("Change Due: {0:C2}", data.RunningTotal));
                }

                transaction.Cash = true;
                transaction.Tendered += -(data.RunningTotal);
                if (transaction.DataContext is Order order)
                {
                    transaction.Tendered = order.Total + (-data.RunningTotal);
                    transaction.Change = transaction.Tendered - order.Total;
                }
                ReceiptPrinter printer = new ReceiptPrinter();
                printer.Print(transaction.ReceiptText());

                var mainWindow = this.FindAncestor<MainWindow>();
                var orderControl = new OrderControl();
                orderControl.DataContext = new Order();
                mainWindow.WindowContainer.Child = orderControl;
            }
        }

        /// <summary>
        /// Calculates the appropriate change to give to the Customer
        /// </summary>
        private int[] CalculateChange()
        {
            int[] ChangeList = new int[10];
            if (DataContext is CashRegisterModelView data)
            {
                int change = (int)(Math.Round(-data.RunningTotal, 2) * 100);

                int hundreds = (change / 10000);
                int fifties = ((change % 10000) / 5000);
                int twenties = (((change % 10000) % 5000) / 2000);
                int tens = ((((change % 10000) % 5000) % 2000) / 1000);
                int fives = (((((change % 10000) % 5000) % 2000) % 1000) / 500);
                int ones = ((((((change % 10000) % 5000) % 2000) % 1000) % 500) / 100);
                int quarters = (((((((change % 10000) % 5000) % 2000) % 1000) % 500) % 100) / 25);
                int dimes = ((((((((change % 10000) % 5000) % 2000) % 1000) % 500) % 100) % 25) / 10);
                int nickels = (((((((((change % 10000) % 5000) % 2000) % 1000) % 500) % 100) % 25) % 10) / 5);
                int pennies = (((((((((change % 10000) % 5000) % 2000) % 1000) % 500) % 100) % 25) % 10) % 5);

                if (CashRegisterModelView.Drawer.Hundreds > 0 && hundreds > 0)
                {
                    data.Hundreds -= hundreds;
                }
                if (CashRegisterModelView.Drawer.Fifties > 0 && fifties > 0)
                {
                    data.Fifties -= fifties;
                }
                if (CashRegisterModelView.Drawer.Twenties > 0 && twenties > 0)
                {
                    data.Hundreds -= hundreds;
                }
                if (CashRegisterModelView.Drawer.Tens > 0 && tens > 0)
                {
                    data.Tens -= tens;
                }
                if (CashRegisterModelView.Drawer.Fives > 0 && fives > 0)
                {
                    data.Fives -= fives;
                }
                if (CashRegisterModelView.Drawer.Ones > 0 && ones > 0)
                {
                    data.Ones -= ones;
                }
                if (CashRegisterModelView.Drawer.Quarters > 0 && quarters > 0)
                {
                    data.Quarters -= quarters;
                }
                if (CashRegisterModelView.Drawer.Dimes > 0 && dimes > 0)
                {
                    data.Dimes -= dimes;
                }
                if (CashRegisterModelView.Drawer.Nickels > 0 && nickels > 0)
                {
                    data.Nickels -= nickels;
                }
                if (CashRegisterModelView.Drawer.Pennies > 0 && pennies > 0)
                {
                    data.Pennies -= pennies;
                }
                ChangeList[0] = hundreds;
                ChangeList[1] = fifties;
                ChangeList[2] = twenties;
                ChangeList[3] = tens;
                ChangeList[4] = fives;
                ChangeList[5] = ones;
                ChangeList[6] = quarters;
                ChangeList[7] = dimes;
                ChangeList[8] = nickels;
                ChangeList[9] = pennies;
            }
            return ChangeList;
        }

        /// <summary>
        /// Displays the number of appropriate Bills and Coins to return to the customer
        /// </summary>
        /// <param name="calculation"></param>
        /// <returns>String of Instructions of what change to give</returns>
        private string ChangeMessage(int[] calculation)
        {
            StringBuilder sb = new StringBuilder();
            if (calculation[0] > 0) { sb.Append("\nHundreds: " + calculation[0]); }
            if (calculation[1] > 0) { sb.Append("\n Fifties: " + calculation[1]); }
            if (calculation[2] > 0) { sb.Append("\nTwenties: " + calculation[2]); }
            if (calculation[3] > 0) { sb.Append("\n    Tens: " + calculation[3]); }
            if (calculation[4] > 0) { sb.Append("\n   Fives: " + calculation[4]); }
            if (calculation[5] > 0) { sb.Append("\n    Ones: " + calculation[5]); }
            if (calculation[6] > 0) { sb.Append("\nQuarters: " + calculation[6]); }
            if (calculation[7] > 0) { sb.Append("\n   Dimes: " + calculation[7]); }
            if (calculation[8] > 0) { sb.Append("\n Nickels: " + calculation[8]); }
            if (calculation[9] > 0) { sb.Append("\n Pennies: " + calculation[9]); }
            return sb.ToString();
        }
    }
}
