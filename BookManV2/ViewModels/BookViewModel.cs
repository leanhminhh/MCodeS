using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using BookManV2.Models;

namespace BookManV2.ViewModels;

internal class BookViewModel
{
    public BindingList<Book> Books { get; set; } = [
        //new Book { Id = 1, Title = "A new book", Author = "Author", Publisher = "Publisher", ISBN = "ISBN", Year = 2021, Pages = "100" },
        //new Book { Id = 2, Title = "Another book", Author = "Author", Publisher = "Publisher", ISBN = "ISBN", Year = 2021, Pages = "100" },
        //new Book { Id = 3, Title = "Yet another book", Author = "Author", Publisher = "Publisher", ISBN = "ISBN", Year = 2021, Pages = "100" }
        
    ];


    public void TestMethod()
    {
        Books.Add(new Book { Id = Books.Count+1, Title = "A new book", Author = "Author", Publisher = "Publisher", ISBN = "ISBN", Year = 2021, Pages = "100" });
        MessageBox.Show($"There are {Books.Count} books in the shell");
        Books[0].Title = "Changed title";
        MessageBox.Show(Current.Title);
        if (Current != null)
        {
            Books.Remove(Current);
            MessageBox.Show($"Book deleted");
        }
    }
    public Book? Current { get; set; }
    public RelayCommand AddCommand { get; set; }
    public BookViewModel()
    {
        var json = File.ReadAllText("data.json");
        Books = JsonSerializer.Deserialize<BindingList<Book>>(json);
        AddCommand = new RelayCommand((o) =>
        {
            var json = JsonSerializer.Serialize(Books);
            File.WriteAllText("data.json", json); // Write valid JSON
            Books.Add(new Book { Id = Books.Count + 1, Title = "A new book", Author = "Author", Publisher = "Publisher", ISBN = "ISBN", Year = 2021, Pages = "100" });
        }, (o) => true);
    }
}

class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Func<object, bool> _canExecute;
    public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
    {
        _execute = execute;
        _canExecute = canExecute;
    }
    public event EventHandler? CanExecuteChanged;
    public bool CanExecute(object parameter) => _canExecute(parameter);
    public void Execute(object parameter) => _execute(parameter);
    

}