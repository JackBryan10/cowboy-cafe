using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        public class AngryChickenPropertyChangedTests
        {
            // Test 1: Pecos Pulled Pork should implement the INotifyPropertyChanged interface
            [Fact]
            public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
            {
                var pecos = new PecosPulledPork();
                Assert.IsAssignableFrom<INotifyPropertyChanged>(pecos);
            }

            // Test 2: Changing the "Bread" property
            [Fact]
            public void ChangingBreadShouldInvokePropertyChangedForBread()
            {
                var pecos = new PecosPulledPork();
                Assert.PropertyChanged(pecos, "Bread", () =>
                {
                    pecos.Bread = false;
                });
            }

            //Test 3: Changing the "Bread" property should invoke PropertyChanged for "SpecialInstructions"
            [Fact]
            public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
            {
                var pecos = new PecosPulledPork();
                Assert.PropertyChanged(pecos, "SpecialInstructions", () =>
                {
                    pecos.Bread = false;
                });
            }

            //Test 4: Changing the "Pickle" property
            [Fact]
            public void ChangingPickleShouldInvokePropertyChangedForPickle()
            {
                var pecos = new PecosPulledPork();
                Assert.PropertyChanged(pecos, "Pickle", () =>
                {
                    pecos.Pickle = false;
                });
            }

            //Test 5: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
            [Fact]
            public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
            {
                var pecos = new PecosPulledPork();
                Assert.PropertyChanged(pecos, "SpecialInstructions", () =>
                {
                    pecos.Pickle = false;
                });
            }
        }
    }
}
