using System;
using Xunit;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lab07;

namespace lab07Test
{
    public class UnitTest1
    {
        [Fact]
        public void IsEnumerable()
        {
            Assert.IsAssignableFrom<IEnumerable>(new Deck<Card>());
        }

        [Fact]
        public void isTypeCard()
        {
            Assert.IsAssignableFrom<Card>(new Card());
        }

        [Fact]
        public void ExploringXunit()
        {
            Assert.IsType<Card>(new Card());
        }

        [Fact]
        public void NewDeckIsEmpty()
        {
            Assert.Empty(new Deck<Card>());
        }
    }
}
