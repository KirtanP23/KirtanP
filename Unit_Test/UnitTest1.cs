using Final_Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ContactTests
{
    [TestMethod]
    public void ValidatePhoneNumber_ValidNumber_ReturnsTrue()
    {
        // Arrange
        string validPhoneNumber = "1234567890";

        // Act
        bool isValid = Contact.ValidatePhoneNumber(validPhoneNumber);

        // Assert
        Assert.IsTrue(isValid, "Expected true for valid phone number.");
    }

    [TestMethod]
    public void ValidatePhoneNumber_InvalidNumber_ReturnsFalse()
    {
        // Arrange
        string invalidPhoneNumber = "12345";

        // Act
        bool isValid = Contact.ValidatePhoneNumber(invalidPhoneNumber);

        // Assert
        Assert.IsFalse(isValid, "Expected false for invalid phone number.");
    }

    [TestMethod]
    public void ValidatePhoneNumber_EmptyString_ReturnsFalse()
    {
        // Arrange
        string emptyPhoneNumber = "";

        // Act
        bool isValid = Contact.ValidatePhoneNumber(emptyPhoneNumber);

        // Assert
        Assert.IsFalse(isValid, "Expected false for empty phone number.");
    }

    [TestMethod]
    public void ValidatePhoneNumber_NullValue_ReturnsFalse()
    {
        // Arrange
        string nullPhoneNumber = null;

        // Act
        bool isValid = Contact.ValidatePhoneNumber(nullPhoneNumber);

        // Assert
        Assert.IsFalse(isValid, "Expected false for null phone number.");
    }

    [TestMethod]
    public void ValidatePhoneNumber_SpecialCharacters_ReturnsFalse()
    {
        // Arrange
        string phoneNumberWithSpecialChars = "12345@6789";

        // Act
        bool isValid = Contact.ValidatePhoneNumber(phoneNumberWithSpecialChars);

        // Assert
        Assert.IsFalse(isValid, "Expected false for phone number with special characters.");
    }
}
