using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.Views;

internal class MainView
{
    public void HelpView()
    {
        Console.WriteLine("=== HELP ===");
        Console.WriteLine("List - Shows Book List");
        Console.WriteLine("Single - Shows a single Book");
        Console.WriteLine("Help - Shows guide");
        Console.WriteLine("Clear - Clears console");
    }
    public void ClearView()
    {
        Console.Clear();
    }
}