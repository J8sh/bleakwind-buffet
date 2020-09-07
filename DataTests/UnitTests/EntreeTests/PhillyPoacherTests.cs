/*
 * Author: Zachery Brunner
 * Modified by: Joshua Garcia
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        /// <summary>
        /// tests if sirloin are included by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        /// <summary>
        /// tests if onions are included by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        /// <summary>
        /// tests if roll is included by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        /// <summary>
        /// test if we can change the value of sirloins
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
        }

        /// <summary>
        /// test if we can change the value of onions
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = true;
            Assert.True(pp.Onion);
            pp.Onion = false;
            Assert.False(pp.Onion);
        }

        /// <summary>
        /// test if we can change the value of roll
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = true;
            Assert.True(pp.Roll);
            pp.Roll = false;
            Assert.False(pp.Roll);
        }

        /// <summary>
        /// test if the price is right
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        /// <summary>
        /// test if the calories are right
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            uint cal = 784;
            Assert.Equal(cal, pp.Calories);
        }

        /// <summary>
        /// test if the Specialinstructions outputs correctly
        /// </summary>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;
            if (!pp.Sirloin) Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            if (!pp.Onion) Assert.Contains("Hold onions", pp.SpecialInstructions);
            if (!pp.Roll) Assert.Contains("Hold roll", pp.SpecialInstructions);
            if (pp.Sirloin && pp.Onion && pp.Roll) Assert.Empty(pp.SpecialInstructions);

        }

        /// <summary>
        /// test if toString prints out correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Contains("Philly Poacher", pp.ToString());
        }




    }
}