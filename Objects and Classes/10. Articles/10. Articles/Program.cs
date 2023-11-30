
string[] articleInfo = Console.ReadLine().Split(", ");
string title = articleInfo[0];
string content = articleInfo[1];
string author = articleInfo[2];

Article article = new Article(title, content, author);

int numberOfCommond = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfCommond; i++)
{
    string[] command = Console.ReadLine().Split(": ");
    string commandName = command[0];
    string commandParameter = command[1];

    switch (commandName)
    {
        case "Edit":
            article.Edit(commandParameter);
            break;
        case "ChangeAuthor":
            article.ChangeAutor(commandParameter);
            break;
        case "Rename":
            article.Rename(commandParameter);
            break;

    }
}

Console.WriteLine(article);
