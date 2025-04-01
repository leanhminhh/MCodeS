using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BookManV2.Models;
    internal class Book : INotifyPropertyChanged

{
    private string title = "A new book";
    private string author = "Author";
    private string publisher = "Publisher";
    private string iSBN = "ISBN";
    private int year;
    private string pages = "100";

    public int Id { get; set; }
    public string Title 
    {
        get => title; set
        {
            title = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
        }
    }
    public string Author { get => author; set => Set(ref author, value); }
    public string Publisher { get => publisher; set => Set(ref publisher, value); }
    public string ISBN { get => iSBN; set => Set(ref iSBN, value); }
    public int Year { get => year; set => Set(ref year, value); }
    public string Pages { get => pages; set => Set(ref pages, value); }
    void Set<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
    {
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    
    public event PropertyChangedEventHandler PropertyChanged;
}


