using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        // Test 1: Corn Dodgers should implement the INotifyPropertyChanged interface
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var dodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodgers);
        }

        // Test 2: Changing the "Size" property
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Large;
            });
            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Small;
            });
            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Medium;
            });
        }
    }
}
