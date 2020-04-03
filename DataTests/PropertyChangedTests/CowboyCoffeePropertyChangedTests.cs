using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        // Test 1: Cowboy Coffee should implement the INotifyPropertyChanged interface
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        // Test 2: Changing the "Size" property
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Large;
            });
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Small;
            });
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Decaf" property
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = true;
            });
        }

        // Test 4: Changing the "RoomForCream" property
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = true;
            });
        }

        // Test 5: Changing the "RoomForCream" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = true;
            });
        }

        //Test 6: Changing the "Ice" property
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = true;
            });
        }

        // Test 7: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = true;
            });
        }
    }
}
