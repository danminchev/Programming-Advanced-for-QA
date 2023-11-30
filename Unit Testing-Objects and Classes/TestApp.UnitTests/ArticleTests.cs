using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
           this._article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articleData =
        {
            "Article Content Author",
            "Article2 Content2 Author2",
            "Article3 Content3 Author3",
        };

        // Act
        Article result = this._article.AddArticles(articleData);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article article = new Article
        {
            ArticleList = new System.Collections.Generic.List<Article>
                {
                    new Article { Title = "Title3", Content = "Content3", Author = "Author3" },
                    new Article { Title = "Title1", Content = "Content1", Author = "Author1" },
                    new Article { Title = "Title2", Content = "Content2", Author = "Author2" }
                }
        };
        string expected = $"Title1 - Content1: Author1{Environment.NewLine}" +
                          $"Title2 - Content2: Author2{Environment.NewLine}" +
                          $"Title3 - Content3: Author3";

        // Act
        string result = this._article.GetArticleList(article, "content");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByContent()
    {
        // Arrange
        Article article = new Article
        {
            ArticleList = new System.Collections.Generic.List<Article>
                {
                    new Article { Title = "Title3", Content = "Content3", Author = "Author3" },
                    new Article { Title = "Title1", Content = "Content1", Author = "Author1" },
                    new Article { Title = "Title2", Content = "Content2", Author = "Author2" }
                }
        };
        string expected = $"Title1 - Content1: Author1{Environment.NewLine}" +
                          $"Title2 - Content2: Author2{Environment.NewLine}" +
                          $"Title3 - Content3: Author3";

        // Act
        string result = this._article.GetArticleList(article, "title");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article article = new Article();

        // Act
        string result = this._article.GetArticleList(article, "invalid_criteria");

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }
}
