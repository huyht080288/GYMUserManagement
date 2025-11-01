using Microsoft.VisualStudio.TestTools.UnitTesting;
using GYMONE.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMONE.Helper.Tests
{
    [TestClass()]
    public class UtilsTests
    {
        private Utils _utils;

        [TestInitialize]
        public void Setup()
        {
            _utils = new Utils();
        }

        [TestMethod]
        public void GetErrorCode_ReturnsSuccess_WhenCodeIsZero()
        {
            var result = _utils.GetErrorCode(0);
            Assert.AreEqual("Success", result);
        }

        [TestMethod]
        public void GetErrorCode_ReturnsUnknownError_WhenCodeIsMinusOne()
        {
            var result = _utils.GetErrorCode(-1);
            Assert.AreEqual("Unknown Error", result);
        }

        [TestMethod]
        public void GetErrorCode_ReturnsConnectionError_WhenCodeIsMinusTwo()
        {
            var result = _utils.GetErrorCode(-2);
            Assert.AreEqual("Connection Error", result);
        }

        [TestMethod]
        public void GetErrorCode_ReturnsTimeoutError_WhenCodeIsMinusThree()
        {
            var result = _utils.GetErrorCode(-3);
            Assert.AreEqual("Timeout Error", result);
        }

        [TestMethod]
        public void GetErrorCode_ReturnsUndefinedErrorCode_ForOtherValues()
        {
            var result = _utils.GetErrorCode(123);
            Assert.AreEqual("Undefined Error Code", result);
        }

        // Tests for IsAdminUser
        [TestMethod]
        public void IsAdminUser_ReturnsTrue_ForAdminExact()
        {
            var result = _utils.IsAdminUser("admin");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAdminUser_ReturnsTrue_ForAdminDifferentCase()
        {
            var result = _utils.IsAdminUser("Admin");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAdminUser_ReturnsTrue_ForOtherAdminNames()
        {
            Assert.IsTrue(_utils.IsAdminUser("superuser"));
            Assert.IsTrue(_utils.IsAdminUser("Manager")); // case-insensitive
        }

        [TestMethod]
        public void IsAdminUser_ReturnsFalse_ForNonAdmin()
        {
            var result = _utils.IsAdminUser("regularuser");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsAdminUser_ReturnsFalse_ForEmptyString()
        {
            var result = _utils.IsAdminUser(string.Empty);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsAdminUser_ThrowsForNullInput()
        {
            // Method calls userName.ToLower() and will throw on null; assert that behavior.
            _utils.IsAdminUser(null);
        }
    }
}