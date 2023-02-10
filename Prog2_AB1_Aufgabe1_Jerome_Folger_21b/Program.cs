using Prog2_AB1_Aufgabe1_Jerome_Folger_21b;
using System.Reflection.PortableExecutable;

Umfrage umfrage = new Umfrage();

umfrage.StelleFrage("Frage 1", "Wie heisst dein Haustier?");
umfrage.StelleFrage("Frage 1", "Wie heisst dein Haustier?", true);
umfrage.StelleFrage("Frage 1", "Wie heisst dein Haustier?", "Bitte Eingabe machen", "^[a-z]+$");