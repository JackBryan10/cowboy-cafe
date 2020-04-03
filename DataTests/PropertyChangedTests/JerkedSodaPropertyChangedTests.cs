using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        // Test 1: Jerked Soda should implement the INotifyPropertyChanged interface
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        // Test 2: Changing the "Size" property
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Large;
            });
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Small;
            });
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Flavor" property
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.OrangeSoda;
            });
        }

        //Test 4: Changing the "Ice" property
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }

        // Test 5: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }
    }
}
