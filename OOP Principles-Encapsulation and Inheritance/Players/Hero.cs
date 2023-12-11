﻿namespace Players;

public class Hero
{

    public Hero(string username, int leve)
    {
        this.Username = username;
        this.Level = leve;
    }

    public string Username { get; set; }

    public int Level { get; set; }

    public override string ToString()
    {
        return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
    }
}
