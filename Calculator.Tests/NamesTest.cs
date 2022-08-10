using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Tests
{
    public class NamesTest
    {
        [Fact]
        public void Names_GivenName_ReturnsFullName()
        {
            var names = new Names();
            var result = names.DisplayFullName("Angie", "maggie");

            Assert.Equal("angie maggie", result, ignoreCase: true);
        }

        [Fact]
        public void NickName_MustReturnNull()
        {
            var names = new Names();
            names.NickName = "angie";

            Assert.NotNull(names.NickName);
            Assert.True(!string.IsNullOrEmpty(names.NickName));
            Assert.False(string.IsNullOrEmpty(names.NickName));
        }
    }
}
