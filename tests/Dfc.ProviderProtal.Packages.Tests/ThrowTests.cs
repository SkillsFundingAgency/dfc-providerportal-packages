using Dfc.ProviderPortal.Packages;
using System;
using System.Collections.Generic;
using Xunit;

namespace Dfc.ProviderProtal.Packages.Tests
{
    public class ThrowTests
    {
        const string ARGUMENTEXPECTION_MESSAGE = "name cannot be null or empty or whitespace.\r\nParameter name: name";

        [Fact]
        public void Throw_IfNull_OfT_WithArgumentAsNullAndNameAsNull_ThrowsArgumentException()
        {
            // arrange
            object argument = null;
            string name = null;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNull(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNull_OfT_WithArgumentAsNullAndNameAsEmpty_ThrowsArgumentException()
        {
            // arrange
            object argument = null;
            var name = string.Empty;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNull(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNull_OfT_WithArgumentAsNullAndNameAsWhitespaceThrowsArgumentException()
        {
            // arrange
            object argument = null;
            var name = " ";
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNull(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
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
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNullOrEmpty(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNullOrEmpty_WithArgumentAsNullAndNameAsEmpty_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            string name = string.Empty;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNullOrEmpty(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNullOrEmpty_WithArgumentAsNullAndNameAsWhitespace_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            string name = " ";
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNullOrEmpty(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNullOrEmpty_WithArgumentAsNull_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrEmpty(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrEmpty_WithArgumentAsEmpty_ThrowsArgumentException()
        {
            // arrange
            string argument = string.Empty;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrEmpty(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrEmpty_WithArgumentAsNotEmpty_DoesNotThrowArgumentException()
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


        [Fact]
        public void Throw_IfNullOrWhiteSpace_WithArgumentAsNullAndNameAsNull_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            string name = null;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNullOrWhiteSpace(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNullOrWhiteSpace_WithArgumentAsNullAndNameAsEmpty_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            string name = string.Empty;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNullOrWhiteSpace(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNullOrWhiteSpace_WithArgumentAsNullAndNameAsWhitespace_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            string name = " ";
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNullOrWhiteSpace(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNullOrWhiteSpace_WithArgumentAsNull_ThrowsArgumentException()
        {
            // arrange
            string argument = null;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrWhiteSpace(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrWhiteSpace_WithArgumentAsEmpty_ThrowsArgumentException()
        {
            // arrange
            string argument = string.Empty;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrWhiteSpace(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrWhiteSpace_WithArgumentAsWhiteSpace_ThrowsArgumentException()
        {
            // arrange
            string argument = " ";
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrWhiteSpace(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrWhiteSpace_WithArgumentAsNotEmpty_DoesNotThrowArgumentException()
        {
            // arrange
            string argument = "some value";
            var name = nameof(argument);
            ArgumentException expected = null;

            //act
            try
            {
                Throw.IfNullOrWhiteSpace(argument, name);
            }
            catch (ArgumentException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }

        [Fact]
        public void Throw_IfLessThan_Int_WithLimitAs0ArgumentAs0AndNameAsNull_ThrowsArgumentException()
        {
            // arrange
            int limit = 0;
            int argument = 0;
            string name = null;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfLessThan_Int_WithLimitAs0ArgumentAs0AndNameAsEmpty_ThrowsArgumentException()
        {
            // arrange
            int limit = 0;
            int argument = 0;
            string name = string.Empty;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfLessThan_Int_WithLimitAs0ArgumentAs0AndNameAsWhitespace_ThrowsArgumentException()
        {
            // arrange
            int limit = 0;
            int argument = 0;
            string name = " ";
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfLessThan_Int_WithLimitAs1ArgumentAs0_ThrowsArgumentOutOfRangeException()
        {
            // arrange
            int limit = 1;
            int argument = 0;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Throw.IfLessThan(limit, argument, name));
        }

        [Fact]
        public void Throw_IfLessThan_Int_WithLimitAs1ArgumentAs1_DoesNotThrowArgumentOutOfRangeException()
        {
            // arrange
            int limit = 1;
            int argument = 1;
            var name = nameof(argument);
            ArgumentOutOfRangeException expected = null;

            //act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentOutOfRangeException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }

        [Fact]
        public void Throw_IfLessThan_Int_WithLimitAs1ArgumentAs2_DoesNotThrowArgumentOutOfRangeException()
        {
            // arrange
            int limit = 1;
            int argument = 2;
            var name = nameof(argument);
            ArgumentOutOfRangeException expected = null;

            //act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentOutOfRangeException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }

        [Fact]
        public void Throw_IfLessThan_Decimal_WithLimitAs0ArgumentAs0AndNameAsNull_ThrowsArgumentException()
        {
            // arrange
            decimal limit = 0;
            decimal argument = 0;
            string name = null;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfLessThan_Decimal_WithLimitAs0ArgumentAs0AndNameAsEmpty_ThrowsArgumentException()
        {
            // arrange
            decimal limit = 0;
            decimal argument = 0;
            string name = string.Empty;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfLessThan_Decimal_WithLimitAs0ArgumentAs0AndNameAsWhitespace_ThrowsArgumentException()
        {
            // arrange
            decimal limit = 0;
            decimal argument = 0;
            string name = " ";
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfLessThan_Decimal_WithLimitAs1ArgumentAs0_ThrowsArgumentOutOfRangeException()
        {
            // arrange
            decimal limit = 1;
            decimal argument = 0;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Throw.IfLessThan(limit, argument, name));
        }

        [Fact]
        public void Throw_IfLessThan_Decimal_WithLimitAs1ArgumentAs1_DoesNotThrowArgumentOutOfRangeException()
        {
            // arrange
            decimal limit = 1;
            decimal argument = 1;
            var name = nameof(argument);
            ArgumentOutOfRangeException expected = null;

            //act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentOutOfRangeException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }

        [Fact]
        public void Throw_IfLessThan_Decimal_WithLimitAs1ArgumentAs2_DoesNotThrowArgumentOutOfRangeException()
        {
            // arrange
            decimal limit = 1;
            decimal argument = 2;
            var name = nameof(argument);
            ArgumentOutOfRangeException expected = null;

            //act
            try
            {
                Throw.IfLessThan(limit, argument, name);
            }
            catch (ArgumentOutOfRangeException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }

        [Fact]
        public void Throw_IfNullOrEmpty_IEnumerable_OfT_WithArgumentAsNullAndNameAsNull_ThrowsArgumentException()
        {
            // arrange
            IEnumerable<object> argument = null;
            string name = null;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNullOrEmpty(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNullOrEmpty_IEnumerable_OfT_WithArgumentAsNullAndNameAsEmpty_ThrowsArgumentException()
        {
            // arrange
            IEnumerable<object> argument = null;
            string name = string.Empty;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNullOrEmpty(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfNullOrEmpty_IEnumerable_OfT_WithArgumentAsNullAndNameAsWhiteSpace_ThrowsArgumentException()
        {
            // arrange
            IEnumerable<object> argument = null;
            string name = " ";
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfNullOrEmpty(argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }


        [Fact]
        public void Throw_IfNullOrEmpty_IEnumerable_OfT_WithArgumentAsNull_ThrowsArgumentException()
        {
            // arrange
            IEnumerable<object> argument = null;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrEmpty(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrEmpty_IEnumerable_OfT_WithArgumentAsEmpty_ThrowsArgumentException()
        {
            // arrange
            IEnumerable<object> argument = new object[] { };
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentException>(() => Throw.IfNullOrEmpty(argument, name));
        }

        [Fact]
        public void Throw_IfNullOrEmpty_IEnumerable_OfT_WithArgumentAsNotEmpty_DoesNotThrowArgumentException()
        {
            // arrange
            IEnumerable<object> argument = new object[] { new { } };
            var name = nameof(argument);
            ArgumentException expected = null;

            //act
            try
            {
                Throw.IfNullOrEmpty(argument, name);
            }
            catch (ArgumentException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }



        [Fact]
        public void Throw_IfGreaterThan_Int_WithLimitAs0ArgumentAs0AndNameAsNull_ThrowsArgumentException()
        {
            // arrange
            int limit = 0;
            int argument = 0;
            string name = null;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfGreaterThan(limit, argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfGreaterThan_Int_WithLimitAs0ArgumentAs0AndNameAsEmpty_ThrowsArgumentException()
        {
            // arrange
            int limit = 0;
            int argument = 0;
            string name = string.Empty;
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfGreaterThan(limit, argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Throw_IfGreaterThan_Int_WithLimitAs0ArgumentAs0AndNameAsWhitespace_ThrowsArgumentException()
        {
            // arrange
            int limit = 0;
            int argument = 0;
            string name = " ";
            ArgumentException expected = new ArgumentException(ARGUMENTEXPECTION_MESSAGE);
            ArgumentException actual = null;

            // act
            try
            {
                Throw.IfGreaterThan(limit, argument, name);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            //assert
            Assert.Equal(expected.Message, actual.Message);
        }


        [Fact]
        public void Throw_IfGreaterThan_Int_WithLimitAs0ArgumentAs1_ThrowsArgumentOutOfRangeException()
        {
            // arrange
            int limit = 0;
            int argument = 1;
            var name = nameof(argument);

            // act & assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Throw.IfGreaterThan(limit, argument, name));
        }

        [Fact]
        public void Throw_IfGreaterThan_Int_WithLimitAs1ArgumentAs1_DoesNotThrowArgumentOutOfRangeException()
        {
            // arrange
            int limit = 1;
            int argument = 1;
            var name = nameof(argument);
            ArgumentOutOfRangeException expected = null;

            //act
            try
            {
                Throw.IfGreaterThan(limit, argument, name);
            }
            catch (ArgumentOutOfRangeException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }

        [Fact]
        public void Throw_IfGreaterThan_Int_WithLimitAs2ArgumentAs1_DoesNotThrowArgumentOutOfRangeException()
        {
            // arrange
            int limit = 2;
            int argument = 1;
            var name = nameof(argument);
            ArgumentOutOfRangeException expected = null;

            //act
            try
            {
                Throw.IfGreaterThan(limit, argument, name);
            }
            catch (ArgumentOutOfRangeException e)
            {
                expected = e;
            }

            // assert
            Assert.Null(expected);
        }

    }
}
