/*
 * Author: Zachery Brunner
 * Modified by: Joshua Garcia
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        /// <summary>
        /// Test if we are getting the side from the Side base cs file
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak side = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(side);
        }

        /// <summary>
        /// make sure the small size is set as default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak side = new FriedMiraak();
            Assert.Equal(Size.Small, side.Size);
        }

        /// <summary>
        /// test if we can change the size of side
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak side = new FriedMiraak();
            side.Size = Size.Large;
            Assert.Equal(Size.Large, side.Size);
            side.Size = Size.Medium;
            Assert.Equal(Size.Medium, side.Size);
            side.Size = Size.Small;
            Assert.Equal(Size.Small, side.Size);
        }

        /// <summary>
        /// test if Special instructions works correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak side = new FriedMiraak();
            Assert.Empty(side.SpecialInstructions);
        }

        /// <summary>
        /// test if price is correctly set on each size
        /// </summary>
        /// <param name="size"> the enum value of size </param>
        /// <param name="price"> the price of size </param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak side = new FriedMiraak();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        /// <summary>
        /// test if calories is correctly set on each size
        /// </summary>
        /// <param name="size"> value of size </param>
        /// <param name="calories"> value of price </param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak side = new FriedMiraak();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        /// <summary>
        /// test if the toString returns correctly for each size
        /// </summary>
        /// <param name="size"> value of size </param>
        /// <param name="name"> string value of correct output </param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak side = new FriedMiraak();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }




    }
}