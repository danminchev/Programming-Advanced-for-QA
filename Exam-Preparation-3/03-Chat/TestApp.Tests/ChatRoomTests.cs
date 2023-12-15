using System;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        string sender = "Daniel";
        string message = "Hello";

        // Act
        this._chatRoom.SendMessage(sender, message);
        string result = this._chatRoom.DisplayChat();

        // Assert 
        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("Daniel: Hello - Sent at"));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange
        
        // Act
        string result = this._chatRoom.DisplayChat();

        // Assert 
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        string sender1 = "Daniel";
        string sender2 = "Hristo";
        string message1 = "Hello";
        string message2 = "Hi";

        // Act
        this._chatRoom.SendMessage(sender1, message1);
        this._chatRoom.SendMessage(sender2, message2);
        string result = this._chatRoom.DisplayChat();

        // Assert 
        Assert.That(result, Does.Contain("Chat Room Messages:"));
        Assert.That(result, Does.Contain("Daniel: Hello - Sent at"));
        Assert.That(result, Does.Contain("Hristo: Hi - Sent at"));
    }
}
