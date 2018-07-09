using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringProcessTest
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void Test_uniqueCharacters()
        {
            //Arrange
            //bool expected = true;
            string str = "abcde";

            //Act
            bool res = StringProcessing.StringProcess.isstringUnique(str);

            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Test_Permutation()
        {
            //Arrange
            //bool expected = true;
            string str1 = "abcd";
            string str2 = "bcad";

            //Act
            bool res = StringProcessing.StringProcess.checkPermutation(str1,str2);

            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Test_ReplaceWhiteSpace()
        {
            //Arrange
            string expected = "%20a%20a%20a%20";
            string str = " a a a ";

            //Act
            string res = StringProcessing.StringProcess.stringReplace(str);

            //Assert
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void Test_stringOperation()
        {
            //Arrange
            //bool expected = true;
            string str1 = "abcde";
            string str2 = "abcdef";

            //Act
            bool res = StringProcessing.StringProcess.modifyString(str1,str2);

            //Assert
            Assert.IsTrue(res);
        }
    }
}
