using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests
{
    public class MenuTest
    {
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        public void EntreesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void EntreesShouldHaveOnlySevenItems()
        {
            Assert.Equal(7, Menu.Entrees().Count());
        }


        [Theory]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        public void SidesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void SidesShouldContainEachSizeOfItem()
        {
            Size size = Size.Small;
            int loops = 0;
            foreach (Side side in Menu.Sides())
            {
                Assert.Equal(size, side.Size);
                if (size == Size.Large) { size = Size.Small; }
                else { size++; }
                loops++;
            }
            Assert.Equal(12, loops);
        }

        [Fact]
        public void SidesShouldHaveOnlyTwelveItems()
        {
            Assert.Equal(12, Menu.Sides().Count());
        }

        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void DrinksShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void DrinksShouldContainEachSizeOfItem()
        {
            Size size = Size.Small;
            int loops = 0;
            foreach (Drink drink in Menu.Drinks())
            {
                Assert.Equal(size, drink.Size);
                if (size == Size.Large) { size = Size.Small; }
                else { size++; }
                loops++;
            }
            Assert.Equal(12, loops);
        }

        [Fact]
        public void DrinksShouldHaveOnlyTwelveItems()
        {
            Assert.Equal(12, Menu.Drinks().Count());
        }

        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void CompleteMenuShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.CompleteMenu())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        [Fact]
        public void CompleteMenuShouldHaveOnlyThirtyOneItems()
        {
            Assert.Equal(31, Menu.CompleteMenu().Count());
        }

        [Theory]
        [InlineData(31, null)]
        [InlineData(1, "Cowpoke Chili")]
        [InlineData(8, "Small")]
        [InlineData(4, "cow")]
        public void SearchShouldReturnProperValues(int expect, string term)
        {
            IEnumerable<IOrderItem> list;

            list = Menu.Search(Menu.CompleteMenu(), term);
            Assert.Equal(expect, list.Count());
        }

        [Theory]
        [InlineData(31, null)]
        [InlineData(7, new string[] { "Entrees" })]
        [InlineData(12, new string[] { "Sides" })]
        [InlineData(12, new string[] { "Drinks" })]
        [InlineData(19, new string[] { "Entrees", "Sides" })]
        [InlineData(19, new string[] { "Entrees", "Drinks" })]
        [InlineData(24, new string[] { "Drinks", "Sides" })]
        [InlineData(31, new string[] { "Entrees", "Sides", "Drinks" })]
        public void FilterByCategoryShouldReturnProperValues(int expect, IEnumerable<string> category)
        {
            IEnumerable<IOrderItem> list;
            list = Menu.FilterByCategory(Menu.CompleteMenu(), category);
            Assert.Equal(expect, list.Count());
        }

        [Theory]
        [InlineData(31, null, null)]
        [InlineData(3, (uint)0, (uint)0)]
        [InlineData(0, (uint)1000, (uint)1000)]
        [InlineData(31, (uint)0, (uint)1000)]
        public void FilterByCaloriesShouldReturnProperValues(int expect, uint? min, uint? max)
        {
            IEnumerable<IOrderItem> list;
            list = Menu.FilterByCalories(Menu.CompleteMenu(), min, max);
            Assert.Equal(expect, list.Count());
        }

        [Theory]
        [InlineData(31, null, null)]
        [InlineData(3, 0.12, 0.12)]
        [InlineData(0, 100.00, 100.00)]
        [InlineData(31, 0.00, 10.00)]
        public void FilterByPriceShouldReturnProperValues(int expect, double? min, double? max)
        {
            IEnumerable<IOrderItem> list;
            list = Menu.FilterByPrice(Menu.CompleteMenu(), min, max);
            Assert.Equal(expect, list.Count());
        }
    }
}
