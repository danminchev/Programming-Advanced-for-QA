using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string title = "Test Task";
        DateTime dueDate = DateTime.Now;

        // Act
        _toDoList.AddTask(title, dueDate);

        // Use reflection to access private field "_tasks"
        var tasksField = typeof(ToDoList).GetField("_tasks", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var tasks = (System.Collections.Generic.List<TestApp.Todo.TaskItem>)tasksField.GetValue(_toDoList);

        // Assert
        Assert.AreEqual(1, tasks.Count, "Task not added successfully");
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title = "Test Task";
        DateTime dueDate = DateTime.Now;
        _toDoList.AddTask(title, dueDate);

        // Act
        _toDoList.CompleteTask(title);

        // Log the result of DisplayTasks
        string displayTasksResult = _toDoList.DisplayTasks();
        Console.WriteLine(displayTasksResult);

        // Assert
        Assert.IsTrue(displayTasksResult.Contains("[✓]"), "Task not marked as completed");
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string title = "Nonexistent Task";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _toDoList.CompleteTask(title), "Expected ArgumentException not thrown");
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Act
        string displayResult = _toDoList.DisplayTasks();

        // Assert
        Assert.AreEqual("To-Do List:", displayResult.Trim(), "Expected empty To-Do List");
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        _toDoList.AddTask("Task 1", DateTime.Now);
        _toDoList.AddTask("Task 2", DateTime.Now.AddDays(1));

        // Act
        string displayResult = _toDoList.DisplayTasks();

        // Assert
        Assert.IsTrue(displayResult.Contains("[ ] Task 1 - Due:"), "Task 1 not displayed correctly");
        Assert.IsTrue(displayResult.Contains("[ ] Task 2 - Due:"), "Task 2 not displayed correctly");
    }
}
