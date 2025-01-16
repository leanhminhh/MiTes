using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BookMan.Controller;

namespace BookMan.Framework;

internal static class Router
{
    static BookControllers bookController = new();
    static MainController mainController = new();
    public static void Forward(string query)
    {
        var tokens = query.Split('&');
        var route = tokens[0].Trim();

        switch (route.ToLower())
        {
            case "help":
                mainController.Help();
                break;
            case "clear":
                mainController.Clear();
                break;
            case "list":
                bookController.List();
                break;
            case "single":
                var parameters = tokens[1].Trim();
                var p = GetParams(parameters);
                int id = int.Parse(p["id"]);
                bookController.Single(id);
                break;
            default:
                break;

        }
    }
    static Dictionary<string, string> GetParams(string query)
    {

        var keyValues = query.Split('&');
        var dictionary = new Dictionary<string, string>();
        foreach (var pair in keyValues)
        {
            var items = pair.Split('=');
            dictionary.Add(items[0].Trim(), items[1].Trim());
        }
        return dictionary;
    }
}