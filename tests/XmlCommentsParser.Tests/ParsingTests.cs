using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XmlCommentsParser.Tests
{
    [TestClass]
    public class ParsingTests
    {
        [TestMethod]
        public void ParseTestFile()
        {
            // Arrange
            var file = @"c:\temp\TestDoc.xml";

            // Act
            var doc = XmlComments.Parse(file);

            // Assert
            Assert.AreEqual(doc.Members.Count(), 4);
            Assert.AreEqual(doc.Assembly.Name, "TestDoc");
        }
    }
}
