using System;

interface IMovieOperations
{
    void Add(string title,string time);
    void Search(string keyword);
    void DisplayAll();
    void GenerateReport();
}