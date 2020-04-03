using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        // Test 1: Water should implement the INotifyPropertyChanged interface
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        // Test 2: Changing the "Size" property
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Large;
            });
            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = Size.Small;
            });
            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Lemon" property
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = true;
            });
        }

        // Test 4: Changing the "Lemon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = true;
            });
        }

        //Test 5: Changing the "Ice" property
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }

        // Test 6: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }
    }
}
