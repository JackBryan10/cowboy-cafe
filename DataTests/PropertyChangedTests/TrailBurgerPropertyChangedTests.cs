using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        // Test 1: Trail Burger should implement the INotifyPropertyChanged interface
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var trail = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trail);
        }

        // Test 2: Changing the "Bun" property
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Bun", () =>
            {
                trail.Bun = false;
            });
        }

        //Test 3: Changing the "Bun" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Bun = false;
            });
        }

        // Test 4: Changing the "Ketchup" property
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Ketchup", () =>
            {
                trail.Ketchup = false;
            });
        }

        //Test 5: Changing the "Ketchup" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Ketchup = false;
            });
        }

        // Test 6: Changing the "Mustard" property
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Mustard", () =>
            {
                trail.Mustard = false;
            });
        }

        //Test 7: Changing the "Mustard" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Mustard = false;
            });
        }

        // Test 8: Changing the "Pickle" property
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Pickle", () =>
            {
                trail.Pickle = false;
            });
        }

        //Test 9: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Pickle = false;
            });
        }

        // Test 10: Changing the "Cheese" property
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Cheese", () =>
            {
                trail.Cheese = false;
            });
        }

        //Test 11: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Cheese = false;
            });
        }

    }
}
