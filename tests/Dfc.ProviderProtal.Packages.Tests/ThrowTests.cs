using Dfc.ProviderPortal.Packages;
using System;
using Xunit;

namespace Dfc.ProviderProtal.Packages.Tests
{
    public class ThrowTests
    {
        [Fact]
        public void Throw_IfNull_OfT_WithArgumentAsNullAndNameAsNull_ThrowsArgumentException()
        {
            // arrange
            object argument = null;
            string name = null;

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNull(argument, name));
        }

        [Fact]
        public void Throw_IfNull_OfT_WithArgumentAsNullAndNameAsEmpty_ThrowsArgumentException()
        {
            // arrange
            object argument = null;
            var name = string.Empty;

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNull(argument, name));
        }

        [Fact]
        public void Throw_IfNull_OfT_WithArgumentAsNullAndNameAsWhitespaceThrowsArgumentException()
        {
            // arrange
            object argument = null;
            var name = " ";

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNull(argument, name));
        }

        [Fact]
        public void Throw_IfNull_OfT_WithArgumentAsNull_ThrowsArgumentNullException()
        {
            // arrange
            object argument = null;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentNullException>(() => Throw.IfNull(argument, name));
        }

        [Fact]
        public void Throw_IfNull_OfT_WithArgumentAsNotNull_DoesNotThrowArgumentNullException()
        {
            // arrange
            object argument = new { };
            var name = nameof(argument);
            ArgumentNullException expected = null;

            //act
            try
            {
                Throw.IfNull(argument, name);
            }
            catch (ArgumentNullException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }

        [Fact]
        public void Throw_IfNullOrEmpty_WithArgumentAsNullAndNameAsNull_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            string name = null;

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrEmpty(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrEmpty_WithArgumentAsNullAndNameAsEmpty_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            string name = string.Empty;

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrEmpty(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrEmpty_WithArgumentAsNullAndNameAsWhitespace_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            string name = " ";

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrEmpty(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrEmpty_OfT_WithArgumentAsNull_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrEmpty(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrEmpty_OfT_WithArgumentAsEmpty_ThrowsArgumentException()
        {
            // arrange
            string argument = string.Empty;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrEmpty(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrEmpty_OfT_WithArgumentAsNotEmpty_DoesNotThrowArgumentException()
        {
            // arrange
            string argument = "some value";
            var name = nameof(argument);
            ArgumentException expected = null;

            //act
            try
            {
                Throw.IfNull(argument, name);
            }
            catch (ArgumentException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }
    }
}
