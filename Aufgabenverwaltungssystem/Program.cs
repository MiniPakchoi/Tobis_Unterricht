﻿using Aufgabenverwaltungssystem;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Erstelle mehrere Aufgabenobjekte
        Tasky task1 = new Tasky("Dokumentation schreiben", "Schreibe die Projektdokumentation bis zum Ende der Woche", new DateTime(2024, 7, 7));
        Tasky task2 = new Tasky("Code-Review durchführen", "Überprüfe den Code des neuen Features", new DateTime(2024, 7, 5));

        // Rufe die Beschreibungen ab und gib sie aus
        Console.WriteLine(task1.GetTaskInfo());
        Console.WriteLine(task2.GetTaskInfo());
        

        // Markiere die erste Aufgabe als erledigt
        Console.WriteLine("\nAb hier sind die erledigten Tasky");
        
        task1.CompleteTask();
        Console.WriteLine(task1.GetTaskInfo());
        

        // Verlängere das Fälligkeitsdatum der zweiten Aufgabe
        Console.WriteLine("\nAb hier sind neue Fälligkeiten");
        task2.ExtendDueDate(new DateTime(2024, 7, 10));
        Console.WriteLine(task2.GetTaskInfo());
    }
}