/* Author: Jack Walter
 * Class Name: TransactionControl.xaml.cs
 * Purpose: Interaction logic for TransactionControl.xaml
*/
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// Value for if credit is used for payment
        /// </summary>
        private bool credit = false;

        /// <summary>
        /// Value for if cash is used for payment
        /// </summary>
        public bool Cash = false;

        /// <summary>
        /// Amount Tendered in Cash
        /// </summary>
        public double Tendered = 0;

        /// <summary>
        /// Amount of change to return to customer
        /// </summary>
        public double Change = 0;

        /// <summary>
        /// Constructor for the TransactionControl User Control
        /// </summary>
        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the Credit Payment Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditPaymentButton_Click(object sender, RoutedEventArgs e)
        {
            Cash = false;
            CardTerminal card = new CardTerminal();
            ReceiptPrinter printer = new ReceiptPrinter();
            if (DataContext is Order order)
            {
                switch (card.ProcessTransaction(order.Total))
                {
                    case ResultCode.Success:
                        credit = true;
                        printer.Print(ReceiptText());
                        CancelOrderButton_Click(new object(), new RoutedEventArgs());
                        break;
                    case ResultCode.InsufficentFunds:
                        MessageBox.Show("Error: " + ResultCode.InsufficentFunds.ToString());
                        break;
                    case ResultCode.CancelledCard:
                        MessageBox.Show("Error: " + ResultCode.CancelledCard.ToString());
                        break;
                    case ResultCode.ReadError:
                        MessageBox.Show("Error: " + ResultCode.ReadError.ToString());
                        break;
                    case ResultCode.UnknownErrror:
                        MessageBox.Show("Error: " + ResultCode.UnknownErrror.ToString());
                        break;
                }
            }
        }

        /// <summary>
        /// Event handler for when the Cash Payment Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashPaymentButton_Click(object sender, RoutedEventArgs e)
        {
            credit = false;
            if (DataContext is Order order)
            {
                var mainWindow = this.FindAncestor<MainWindow>();
                var cashRegisterControl = new CashRegisterControl(this);
                var cashRegisterModelView = new CashRegisterModelView();
                cashRegisterModelView.RunningTotal = Math.Round(order.Total, 2);
                cashRegisterControl.DataContext = cashRegisterModelView;
                mainWindow.WindowContainer.Child = cashRegisterControl;
            }
        }

        /// <summary>
        /// Event handler for when the Cancel Order Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = this.FindAncestor<MainWindow>();
            var orderControl = new OrderControl();
            orderControl.DataContext = new Order();
            mainWindow.WindowContainer.Child = orderControl;
        }

        /// <summary>
        /// Text that is to be displayed on the receipt
        /// </summary>
        /// <returns>String of text</returns>
        public string ReceiptText()
        {
            StringBuilder sb = new StringBuilder();

            if (DataContext is Order order)
            {
                sb.Append(String.Format("\n\n\n\n\t\t\t  ORDER NUMBER #{0}\n\n\t\t\t  **COWBOY CAFE**\n{1,20:d}   {1:t}", order.OrderNumber, DateTime.Now));
                sb.Append("\n_____________________________________________\n");
                foreach (IOrderItem item in order.Items)
                {
                    sb.Append(String.Format("\n\t{0,-30} {1,9:C2}", item.ToString().ToUpper(), item.Price));
                    if (item.SpecialInstructions != null)
                    {
                        foreach (string s in item.SpecialInstructions)
                        {
                            sb.Append("\n\t\t*" + s.ToUpper());
                        }
                    }
                }
                sb.Append(String.Format("\n\t\t\t\t\tSUBTOTAL:{0,15:C2}\n\t\t\t\t   TAX 16.0%:{1,15:C2}\n---------------------------------------------\n\t\t\t\t\t   TOTAL:{2,15:C2}", 
                    order.Subtotal, order.Subtotal*0.16, order.Total));
                if (Cash)
                {
                    sb.Append("\n\t\t\t----CASH TENDER----");
                    sb.Append(String.Format("\n\t\t\t\t\tTENDERED:{0,15:C2}\n\t\t\t\t  CHANGE DUE:{1,15:C2}", Tendered, Change));
                }
                if (credit) { sb.Append("\n\t\t\t----CREDIT TENDER----"); }

                sb.Append("\n_____________________________________________" +
                    "\n\nTHANK YOU FOR DINING AT COWBOY CAFE. YEE-HAW!\n\n\n\n");
            }
            return sb.ToString();
        }
    }
}
