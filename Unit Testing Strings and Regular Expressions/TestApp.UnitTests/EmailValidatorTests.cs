using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("Didko.@abv.bg")]
    [TestCase("Didko_lb@abv.bg")]
    [TestCase("Didko-%lb+@abv.bg")]
    [TestCase("danielminchev@gmail.com")]
    [TestCase("danielminchev@g1-mail.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("@abv.bg")]
    [TestCase("Didko_lb-abv.bg")]
    [TestCase("Didko-%lb+@")]
    [TestCase("gmail.com.daniel?")]
    [TestCase("?@g1-mail.com")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
