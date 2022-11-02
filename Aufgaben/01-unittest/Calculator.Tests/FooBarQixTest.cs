using System;
using Xunit;

namespace Calculator.Tests
{
    public class FooBarQixTest
    {
        [Fact]
        public void One_applyDeterminer_returnOne()
        {

            int a = 1;
            string expected = "1";
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.determiner(a);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Two_applyDeterminer_returnTwo()
        {

            int a = 2;
            string expected = "2";
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.determiner(a);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Thre_applyDeterminer_returnFoo()
        {

            int a = 3;
            string expected = "Foo";
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.determiner(a);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Five_applyDeterminer_returnBar()
        {

            int a = 5;
            string expected = "Bar";
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.determiner(a);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Seven_applyDeterminer_returnQix()
        {

            int a = 7;
            string expected = "Qix";
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.determiner(a);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Fifteen_applyDeterminer_returnFooBar()
        {

            int a = 15;
            string expected = "FooBar";
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.determiner(a);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void OnehundredFive_applyDeterminer_returnFooBarQix()
        {

            int a = 105;
            string expected = "FooBarQix";
            FooBarQix fooBarQix = new FooBarQix();

            // Act
            var result = fooBarQix.determiner(a);

            // Assert
            Assert.Equal(expected, result);
        }


    }
}