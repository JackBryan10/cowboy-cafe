/* Author: Jack Walter 
 * Class Name: CashRegisterModelView.cs
 * Purpose: Model View for the Cash Register
 * (Modified from Lab Assignment)
*/
using System.Collections.Generic;
using System.ComponentModel;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Model View for the Cash Register
    /// </summary>
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer all transactions use
        /// </summary>
        public static CashDrawer Drawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        public double TotalValue => Drawer.TotalValue;

        /// <summary>
        /// List of all Bills paid 
        /// </summary>
        public List<Bills> BillsAdded = new List<Bills>();

        /// <summary>
        /// List of all Coins paid
        /// </summary>
        public List<Coins> CoinsAdded = new List<Coins>();

        private double runningTotal;
        /// <summary>
        /// The running total of money added to the drawer.
        /// </summary>
        public double RunningTotal 
        {
            get { return runningTotal; }
            set 
            {
                if (runningTotal== value) return;
                runningTotal = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RunningTotal"));
            }
        }

        /// <summary>
        /// Gets and sets the amount of Pennies in the drawer
        /// </summary>
        public int Pennies
        {
            get => Drawer.Pennies;
            set
            {
                if (Drawer.Pennies == value || value < 0) return;
                var quantity = value - Drawer.Pennies;
                if (quantity > 0) { Drawer.AddCoin(Coins.Penny, quantity); }
                else { Drawer.RemoveCoin(Coins.Penny, -quantity); }
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Nickels in the drawer
        /// </summary>
        public int Nickels
        {
            get => Drawer.Nickels;
            set
            {
                if (Drawer.Nickels == value || value < 0) return;
                var quantity = value - Drawer.Nickels;
                if (quantity > 0) { Drawer.AddCoin(Coins.Nickel, quantity); }
                else { Drawer.RemoveCoin(Coins.Nickel, -quantity); }
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Dimes in the drawer
        /// </summary>
        public int Dimes
        {
            get => Drawer.Dimes;
            set
            {
                if (Drawer.Dimes == value || value < 0) return;
                var quantity = value - Drawer.Dimes;
                if (quantity > 0) { Drawer.AddCoin(Coins.Dime, quantity); }
                else { Drawer.RemoveCoin(Coins.Dime, -quantity); }
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Quarters in the drawer
        /// </summary>
        public int Quarters
        {
            get => Drawer.Quarters;
            set
            {
                if (Drawer.Quarters == value || value < 0) return;
                var quantity = value - Drawer.Quarters;
                if (quantity > 0) { Drawer.AddCoin(Coins.Quarter, quantity); }
                else { Drawer.RemoveCoin(Coins.Quarter, -quantity); }
                InvokePropertyChanged("Quarters");
            }
        }
        
        /// <summary>
        /// Gets and sets the amount of Ones in the drawer
        /// </summary>
        public int Ones
        {
            get => Drawer.Ones;
            set
            {
                if (Drawer.Ones == value || value < 0) return;
                var quantity = value - Drawer.Ones;
                if (quantity > 0) { Drawer.AddBill(Bills.One, quantity); }
                else { Drawer.RemoveBill(Bills.One, -quantity); }
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Fives in the drawer
        /// </summary>
        public int Fives
        {
            get => Drawer.Fives;
            set
            {
                if (Drawer.Fives == value || value < 0) return;
                var quantity = value - Drawer.Fives;
                if (quantity > 0) { Drawer.AddBill(Bills.Five, quantity); }
                else { Drawer.RemoveBill(Bills.Five, -quantity); }
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Tens in the drawer
        /// </summary>
        public int Tens
        {
            get => Drawer.Tens;
            set
            {
                if (Drawer.Tens == value || value < 0) return;
                var quantity = value - Drawer.Tens;
                if (quantity > 0) { Drawer.AddBill(Bills.Ten, quantity); }
                else { Drawer.RemoveBill(Bills.Ten, -quantity); }
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Twenties in the drawer
        /// </summary>
        public int Twenties
        {
            get => Drawer.Twenties;
            set
            {
                if (Drawer.Twenties == value || value < 0) return;
                var quantity = value - Drawer.Twenties;
                if (quantity > 0) { Drawer.AddBill(Bills.Twenty, quantity); }
                else { Drawer.RemoveBill(Bills.Twenty, -quantity); }
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Fifties in the drawer
        /// </summary>
        public int Fifties
        {
            get => Drawer.Fifties;
            set
            {
                if (Drawer.Fifties == value || value < 0) return;
                var quantity = value - Drawer.Fifties;
                if (quantity > 0) { Drawer.AddBill(Bills.Fifty, quantity); }
                else { Drawer.RemoveBill(Bills.Fifty, -quantity); }
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// Gets and sets the amount of Hundreds in the drawer
        /// </summary>
        public int Hundreds
        {
            get => Drawer.Hundreds;
            set
            {
                if (Drawer.Hundreds == value || value < 0) return;
                var quantity = value - Drawer.Hundreds;
                if (quantity > 0) { Drawer.AddBill(Bills.Hundred, quantity); }
                else { Drawer.RemoveBill(Bills.Hundred, -quantity); }
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// Invokes the corresponding property for the denomination passed in
        /// </summary>
        /// <param name="denomination">Name of denomination property changed</param>
        private void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
