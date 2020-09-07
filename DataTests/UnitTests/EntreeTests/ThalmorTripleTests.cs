/*
 * Author: Zachery Brunner
 * Modified by: Joshua Garcia
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        /// <summary>
        /// test if bun is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Bun);
        }

        /// <summary>
        /// test if ketchup is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Ketchup);
        }

        /// <summary>
        /// test if mustard is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Mustard);
        }

        /// <summary>
        /// test if pickle is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Pickle);
        }

        /// <summary>
        /// test if cheese is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Cheese);
        }

        /// <summary>
        /// test if tomato is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Tomato);
        }

        /// <summary>
        /// test if lettuce is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Lettuce);
        }

        /// <summary>
        /// test if mayo is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Mayo);
        }

        /// <summary>
        /// test if bacon is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Bacon);
        }

        /// <summary>
        /// test if egg is included by default
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Egg);
        }

        /// <summary>
        /// test if we can change the value of bun
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Bun = true;
            Assert.True(entree.Bun);
            entree.Bun = false;
            Assert.False(entree.Bun);
        }

        /// <summary>
        /// test if we can change the value of ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Ketchup = true;
            Assert.True(entree.Ketchup);
            entree.Ketchup = false;
            Assert.False(entree.Ketchup);
        }

        /// <summary>
        /// test if we can change the value of mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Mustard = true;
            Assert.True(entree.Mustard);
            entree.Mustard = false;
            Assert.False(entree.Mustard);
        }

        /// <summary>
        /// test if we can change the value of pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Pickle = true;
            Assert.True(entree.Pickle);
            entree.Pickle = false;
            Assert.False(entree.Pickle);
        }

        /// <summary>
        /// test if we can change the value of cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Cheese = true;
            Assert.True(entree.Cheese);
            entree.Cheese = false;
            Assert.False(entree.Cheese);
        }

        /// <summary>
        /// test if we can change the value of tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Tomato = true;
            Assert.True(entree.Tomato);
            entree.Tomato = false;
            Assert.False(entree.Tomato);
        }

        /// <summary>
        /// test if we can change the value of lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Lettuce = true;
            Assert.True(entree.Lettuce);
            entree.Lettuce = false;
            Assert.False(entree.Lettuce);
        }

        /// <summary>
        /// test if we can change the value of mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Mayo = true;
            Assert.True(entree.Mayo);
            entree.Mayo = false;
            Assert.False(entree.Mayo);
        }

        /// <summary>
        /// test if we can change the value of bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Bacon = true;
            Assert.True(entree.Bacon);
            entree.Bacon = false;
            Assert.False(entree.Bacon);
        }

        /// <summary>
        /// test if we can change the value of egg
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Egg = true;
            Assert.True(entree.Egg);
            entree.Egg = false;
            Assert.False(entree.Egg);
        }

        /// <summary>
        /// test if the price is right
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.Equal(8.32, entree.Price);
        }

        /// <summary>
        /// test if the calories are right
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple entree = new ThalmorTriple();
            uint cal = 943;
            Assert.Equal(cal, entree.Calories);
        }

        /// <summary>
        /// test if the Specialinstructions outputs correctly
        /// </summary>
        /// <param name="includeBun"> value of Bun </param>
        /// <param name="includeKetchup"> value of Ketchup </param>
        /// <param name="includeMustard"> value of Mustard </param>
        /// <param name="includePickle"> value of pickle </param>
        /// <param name="includeCheese"> value of cheese </param>
        /// <param name="includeTomato"> value of tomato </param>
        /// <param name="includeLettuce"> value of lettuce </param>
        /// <param name="includeMayo"> value of mayo </param>
        /// <param name="includeBacon"> value of bacon </param>
        /// <param name="includeEgg"> value of egg </param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Bun = includeBun;
            entree.Ketchup = includeKetchup;
            entree.Mustard = includeMustard;
            entree.Pickle = includePickle;
            entree.Cheese = includeCheese;
            entree.Tomato = includeTomato;
            entree.Lettuce = includeLettuce;
            entree.Mayo = includeMayo;
            entree.Bacon = includeBacon;
            entree.Egg = includeEgg;
            if (!entree.Bacon) Assert.Contains("Hold bacon", entree.SpecialInstructions);
            if (!entree.Egg) Assert.Contains("Hold egg", entree.SpecialInstructions);
            if (entree.Bacon && entree.Egg) Assert.Empty(entree.SpecialInstructions);
        }

        /// <summary>
        /// test if toString prints out correctly
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.Contains("Thalmor Triple", entree.ToString());
        }




    }
}