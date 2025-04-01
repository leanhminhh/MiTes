using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using StudentManagement.Models;

namespace StudentManagement.ViewModels
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; } = new();
        private readonly string _filePath = "students.json";

        public async Task LoadStudentsAsync()
        {
            if (File.Exists(_filePath))
            {
                var json = await File.ReadAllTextAsync(_filePath);
                var students = JsonSerializer.Deserialize<ObservableCollection<Student>>(json);
                Students.Clear();
                foreach (var student in students)
                    Students.Add(student);
            }
        }

        public async Task SaveStudentsAsync()
        {
            var json = JsonSerializer.Serialize(Students);
            await File.WriteAllTextAsync(_filePath, json);
        }
    }
}