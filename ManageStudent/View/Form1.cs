using System;
using System.Windows.Forms;
using StudentManagement.ViewModels;

namespace StudentManagement.Views
{
    public partial class Form1 : Form
    {
        private readonly StudentViewModel _viewModel;
        
        public Form1(StudentViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            dataGridView1.DataSource = _viewModel.Students;
        }
    }
}