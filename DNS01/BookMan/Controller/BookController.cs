using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMan.Repositories;
using BookMan.Views;

namespace BookMan.Controller;

internal class BookControllers
{
    BookRepository _respository = new();
    BookView _view = new();

    public void List()
    {
        var model = _respository.Retrieve();
        _view.ListView(model);
    }

    public void Single(int id)
    {
        var model = _respository.Retrieve(id);
        _view.SingleView(model);
    }
}