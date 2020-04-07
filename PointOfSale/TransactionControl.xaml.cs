using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.ComponentModel;
using CowboyCafe.Data;
using PointOfSale;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        private bool credit = false;

        private bool cash = false;
        /// <summary>
        /// Constructor for the TransactionControl User Control
        /// </summary>
        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditPaymentButton_Click(object sender, RoutedEventArgs e)
        {
            CardTerminal card = new CardTerminal();
            ReceiptPrinter printer = new ReceiptPrinter();
            if (DataContext is Order order)
            {
                switch (card.ProcessTransaction(order.Total))
                {
                    case ResultCode.Success:
                        printer.Print(ReceiptText());
                        CancelOrderButton_Click(new object(), new RoutedEventArgs());
                        break;
                    case ResultCode.InsufficentFunds:
                        ErroMessageBox.Text = ResultCode.InsufficentFunds.ToString();
                        break;
                    case ResultCode.CancelledCard:
                        ErroMessageBox.Text = ResultCode.CancelledCard.ToString();
                        break;
                    case ResultCode.ReadError:
                        ErroMessageBox.Text = ResultCode.ReadError.ToString();
                        break;
                    case ResultCode.UnknownErrror:
                        ErroMessageBox.Text = ResultCode.UnknownErrror.ToString();
                        break;
                }
            }
            credit = true;
        }

        private void CashPaymentButton_Click(object sender, RoutedEventArgs e)
        {
            cash = true;
        }

        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = this.FindAncestor<MainWindow>();
            var orderControl = new OrderControl();
            orderControl.DataContext = new Order();
            mainWindow.WindowContainer.Child = orderControl;
        }

        private string ReceiptText()
        {
            StringBuilder sb = new StringBuilder();

            if (DataContext is Order order)
            {
                sb.Append("\nOrderNumber #" + order.OrderNumber +
                    "\n" +
                    "\nDate: " + String.Format("{0:d} Time: {0:t}", DateTime.Now) + 
                    "\n");
                foreach (IOrderItem item in order.Items)
                {
                    sb.Append("\n" + item.ToString() + "\t\t" + String.Format("{0:C2}", item.Price));
                    if (item.SpecialInstructions != null)
                    {
                        foreach (string s in item.SpecialInstructions)
                        {
                            sb.Append("\n***" + s);
                        }
                    }
                }
                if(cash) { sb.Append("\nCash"); }
                if (credit) { sb.Append("\nCredit"); }

            }
            return sb.ToString();
        }
    }
}
