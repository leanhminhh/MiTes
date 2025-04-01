using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using StudentManagement.ViewModels;
using StudentManagement.Views;

namespace StudentManagement
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddSingleton<StudentViewModel>();
            services.AddTransient<Form1>();

            using var provider = services.BuildServiceProvider();
            var mainForm = provider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }
    }
}



// create a winform application to manage student information that
// 1 code is organnized in mvvm pattern
// 2 the model class mmust have at least 5 properties
// 3 the view must use the data binding and command binding techniques
//4 data must be stored and loaded from a json file
//5 the application must support all CRUD operations