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
    }
}
