using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public double Subtotal => 0;

        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public void Add(IOrderItem item)
        {

        }

        public void Remove(IOrderItem item)
        {

        }
    }
}
