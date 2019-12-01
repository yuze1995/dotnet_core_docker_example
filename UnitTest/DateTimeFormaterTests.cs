using DotNetCoreDockerExample.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace UnitTest
{
    public class DateTimeFormaterTests
    {
        [Fact]
        public void Format_Format_FormatedDateTime()
        {
            // Arrange
            var time = new DateTime(2019, 12, 1, 13, 17, 45);

            var expect = "2019/12/01 01:17:45";

            var dateTimeFormater = new DateTimeFormater();

            // Act
            var actual = dateTimeFormater.Format(time);

            // Assert
            actual.Should().BeEquivalentTo(expect);
        }
    }
}
