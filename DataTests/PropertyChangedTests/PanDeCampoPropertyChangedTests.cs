using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        // Test 1: Pan de Campo should implement the INotifyPropertyChanged interface
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }

        // Test 2: Changing the "Size" property
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () =>
            {
                pan.Size = Size.Large;
            });
            Assert.PropertyChanged(pan, "Calories", () =>
            {
                pan.Size = Size.Small;
            });
            Assert.PropertyChanged(pan, "Price", () =>
            {
                pan.Size = Size.Medium;
            });
        }
    }
}
