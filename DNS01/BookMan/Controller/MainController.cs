using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMan.Views;

namespace BookMan.Controller;

internal class MainController
{
    MainView view = new();
    public void Help()
    {
        view.HelpView();
    }
    public void Clear()
    {
        view.ClearView();
    }
}
