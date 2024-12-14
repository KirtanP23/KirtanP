using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Final_Assignment;

namespace Final_Assignment_Tests
{
    [TestClass]
    public class ContactTests
    {

        [TestMethod]
        public void Test_ValidatePhoneNumber_InvalidNumber()
        {
            string invalidPhoneNumber = "12345";
            Assert.IsFalse(Contact.ValidatePhoneNumber(invalidPhoneNumber), "An invalid phone number should fail validation.");
        }

        
        [TestMethod]
        public void Test_GetContact_InvalidID()
        {
            Contact retrievedContact = Contact.GetContact(-1);
            Assert.IsNull(retrievedContact, "Contact with invalid ID should return null.");
        }

        [TestMethod]
        public void Test_ToString_ValidContact()
        {
            Contact contact = new Contact(1, "Test", "User", "1234567890", "test.user@example.com");
            string expected = "Test User - 1234567890 (test.user@example.com)";
            Assert.AreEqual(expected, contact.ToString(), "ToString() should return the correct format.");
        }
    }
}
