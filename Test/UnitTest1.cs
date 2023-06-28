using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mail_LIB;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckMailNormal()
        {
            // Arrange
            string mail = "bebrbrab@gneg.sru";
            // Act
            bool actual = Mail.CheckMail(mail);
            // Assert
            Assert.IsTrue(actual);
        }
        // Добавить тестов
        [TestMethod]
        public void GetMailNormal()
        {
            string mail = "bebrbrab@gneg.sru";
            string actual = Mail.GetMail(mail);
            Assert.IsTrue(mail.Length + 1 == actual.Length);
        }
    }
}
