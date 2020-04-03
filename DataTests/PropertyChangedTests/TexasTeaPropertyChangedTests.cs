using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        // Test 1: Texas Tea should implement the INotifyPropertyChanged interface
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var texas = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texas);
        }

        // Test 2: Changing the "Size" property
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var texas = new TexasTea();
            Assert.PropertyChanged(texas, "Size", () =>
            {
                texas.Size = Size.Large;
            });
            Assert.PropertyChanged(texas, "Calories", () =>
            {
                texas.Size = Size.Small;
            });
            Assert.PropertyChanged(texas, "Price", () =>
            {
                texas.Size = Size.Medium;
            });
        }

        // Test 3: Changing the "Sweet" property
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForFlavor()
        {
            var texas = new TexasTea();
            Assert.PropertyChanged(texas, "Sweet", () =>
            {
                texas.Sweet = false;
            });
        }

        //Test 4: Changing the "Ice" property
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var texas = new TexasTea();
            Assert.PropertyChanged(texas, "Ice", () =>
            {
                texas.Ice = false;
            });
        }

        // Test 5: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTea();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Ice = false;
            });
        }

        //Test 6: Changing the "Lemon" property
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForIce()
        {
            var texas = new TexasTea();
            Assert.PropertyChanged(texas, "Lemon", () =>
            {
                texas.Lemon = true;
            });
        }

        // Test 7: Changing the "Lemon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTea();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Lemon = true;
            });
        }
    }
}
