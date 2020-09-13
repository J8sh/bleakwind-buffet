/*
 * Author: Zachery Brunner
 * Modified by: Joshua Garcia
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        /// <summary>
        /// Test if we are getting the Side from the IOrderItem interface cs file
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            VokunSalad side = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }

        /// <summary>
        /// Test if we are getting the side from the Side base cs file
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad side = new VokunSalad();
            Assert.IsAssignableFrom<Side>(side);
        }

        /// <summary>
        /// make sure the small size is set as default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad side = new VokunSalad();
            Assert.Equal(Size.Small, side.Size);
        }

        /// <summary>
        /// test if we can change the size of side
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad side = new VokunSalad();
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
            VokunSalad side = new VokunSalad();
            Assert.Empty(side.SpecialInstructions);
        }

        /// <summary>
        /// test if price is correctly set on each size
        /// </summary>
        /// <param name="size"> the enum value of size </param>
        /// <param name="price"> the price of size </param>
        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad side = new VokunSalad();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        /// <summary>
        /// test if calories is correctly set on each size
        /// </summary>
        /// <param name="size"> value of size </param>
        /// <param name="calories"> value of price </param>
        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad side = new VokunSalad();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        /// <summary>
        /// test if the toString returns correctly for each size
        /// </summary>
        /// <param name="size"> value of size </param>
        /// <param name="name"> string value of correct output </param>
        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad side = new VokunSalad();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }



    }
}