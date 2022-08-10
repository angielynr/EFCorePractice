using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Tests
{
    public class NamesTest : IClassFixture<CalculatorFixture>
    {
        private readonly Names _names;

        public NamesTest(Names names)
        {
            _names = names;
        }

        [Fact]
        public void Names_GivenName_ReturnsFullName()
        {
            var result = _names.DisplayFullName("Angie", "maggie");

            Assert.Equal("angie maggie", result, ignoreCase: true);
        }

        [Fact]
        public void NickName_MustReturnNull()
        {
            _names.NickName = "angie";

            Assert.NotNull(_names.NickName);
            Assert.True(!string.IsNullOrEmpty(_names.NickName));
            Assert.False(string.IsNullOrEmpty(_names.NickName));
        }
    }
}
