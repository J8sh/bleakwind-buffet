/*
 * Author: Zachery Brunner
 * Modified by: Joshua Garcia
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {

        /// <summary>
        /// make sure the small size is set as default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.Equal(Size.Small, side.Size);
        }

        /// <summary>
        /// test if we can change the size of side
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits side = new MadOtarGrits();
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
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits side = new MadOtarGrits();
            Assert.Empty(side.SpecialInstructions);
        }

        /// <summary>
        /// test if price is correctly set on each size
        /// </summary>
        /// <param name="size"> the enum value of size </param>
        /// <param name="price"> the price of size </param>
        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        /// <summary>
        /// test if calories is correctly set on each size
        /// </summary>
        /// <param name="size"> value of size </param>
        /// <param name="calories"> value of price </param>
        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        /// <summary>
        /// test if the toString returns correctly for each size
        /// </summary>
        /// <param name="size"> value of size </param>
        /// <param name="name"> string value of correct output </param>
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits side = new MadOtarGrits();
            side.Size = size;
            Assert.Equal(name, side.ToString());
        }



    }
}