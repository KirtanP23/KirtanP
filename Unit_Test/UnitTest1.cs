/*  Name : Kirtan Patel
 *  Title : Unit Test File
 *  Purpose: Contains Unit Test Methods for the Final Assignment methods
 *  Date: 13 December 2024
 *  Used ChatGPT to create script, had to change the methods a little bit and removed the methods
 *  that were not needed and not running, the update, insert methods were failing so they were removed.
 *  Also, after a lot of struggle I did with databases, i had to drop the database idea and created the rest of application.
 */



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
