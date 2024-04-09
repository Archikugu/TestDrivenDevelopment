using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void removeExtraSpacesFromString()
        {
            //Arrange
            var expression = "    Gökhan Gök    ";
            var expected = "Gökhan Gök";

            //Act
            var actual = StringHelper.RemoveExtraSpaces(expression);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void removeSpacesFromString()
        {
            //Arrange
            var expression = "Gökhan Gök  Fatih Gök  Nagehan   Gök ";
            var expected = "Gökhan Gök Fatih Gök Nagehan Gök";

            //Act
            var actual = StringHelper.RemoveExtraSpaces(expression);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
