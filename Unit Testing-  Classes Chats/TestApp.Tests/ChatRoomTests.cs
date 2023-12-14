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
        string sender = "John";
        string message = "Hello, World!";

        // Act
        _chatRoom.SendMessage(sender, message);

        // Assert
        string displayChatResult = _chatRoom.DisplayChat();
        Assert.IsTrue(displayChatResult.Contains($"{sender}: {message}"), "Message not added to chat successfully");
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Act
        string displayChatResult = _chatRoom.DisplayChat();

        // Assert
        Assert.AreEqual(string.Empty, displayChatResult.Trim(), "Expected empty chat");
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        _chatRoom.SendMessage("Alice", "Hi!");
        _chatRoom.SendMessage("Bob", "Hey there!");

        // Act
        string displayChatResult = _chatRoom.DisplayChat();

        // Assert
        Assert.IsTrue(displayChatResult.Contains("Alice: Hi!"), "Message 1 not displayed correctly");
        Assert.IsTrue(displayChatResult.Contains("Bob: Hey there!"), "Message 2 not displayed correctly");
    }

}
