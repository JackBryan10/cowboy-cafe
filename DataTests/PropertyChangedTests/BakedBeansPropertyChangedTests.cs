using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        // Test 1: Baked Beans should implement the INotifyPropertyChanged interface
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        // Test 2: Changing the "Size" property
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizeCaloriesAndPrice()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Large;
            });
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Small;
            });
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Medium;
            });
        }
    }
}
