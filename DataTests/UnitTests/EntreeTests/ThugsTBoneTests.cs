/*
 * Author: Zachery Brunner
 * Modified by: Joshua Garcia
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        /// <summary>
        /// Test if we are getting the Entree from the IOrderItem interface cs file
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        /// <summary>
        /// Test if we are getting the entree from the Entree base cs file
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        /// <summary>
        /// test if the price is right
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.Equal(6.44, entree.Price);
        }

        /// <summary>
        /// test if the calories are right
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone entree = new ThugsTBone();
            uint cal = 982;
            Assert.Equal(cal, entree.Calories);
        }

        /// <summary>
        /// test if the Specialinstructions outputs correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.Empty(entree.SpecialInstructions);
        }

        /// <summary>
        /// test if toString prints out correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.Contains("Thugs T-Bone", entree.ToString());
        }



    }
}