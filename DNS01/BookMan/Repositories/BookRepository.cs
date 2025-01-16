using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMan.Models;

namespace BookMan.Repositories;

internal class BookRepository
{
    private List<Book> _data = [
        new(){ Id = 0, Title = "C# for you - Vol 1", Authors = "Putin V."},
        new(){ Id = 1, Title = "C# for you - Vol 2", Authors = "Trump D."},
        new(){ Id = 2, Title = "C# for you - Vol 3", Authors = "Biden J."},
        new(){ Id = 3, Title = "C# for you - Vol 4", Authors = "Wrier F."},
        new(){ Id = 4, Title = "C# for you - Vol 5", Authors = "Rutin S."},
        new(){ Id = 5, Title = "C# for you - Vol 6", Authors = "Linda A."},
        new(){ Id = 6, Title = "C# for you - Vol 7", Authors = "Omar W."},
        new(){ Id = 7, Title = "C# for you - Vol 8", Authors = "Quincy B."}
    ];
    public void Create(Book book)
    {
        _data.Add(book);
    }
    public void Create(int id, string title)
    {
        var book = new Book()
        {
            Id = id,
            Title = title
        };
        _data.Add(book);
    }
    public Book[] Retrieve()
    {
        return _data.ToArray();
    }
    public Book Retrieve(int id)
    {
        Book found = null;
        foreach (Book b in _data)
        {
            if (b.Id == id)
            {
                found = b; break;
            }
        }
        return found;
    }
}