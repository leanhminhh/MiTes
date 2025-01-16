using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMan.Models;
using BookMan.Repositories;

namespace BookMan.Views;

internal class BookView
{
    public void ListView(Book[] model)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (Book b in model)
        {
            Console.WriteLine($"[{b.Id}]{b.Title}, {b.Authors}, {b.Year}");
        }
        Console.ResetColor();
    }

    public void SingleView(Book model)
    {
        if (model == null)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("No book to display");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Id\t {model.Id}");
            Console.WriteLine($"Title\t {model.Title}");
            Console.WriteLine($"Author\t {model.Authors}");
            Console.WriteLine($"Year\t {model.Year}");
            Console.ResetColor();
        }

    }
}