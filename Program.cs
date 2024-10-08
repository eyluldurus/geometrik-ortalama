// See https://aka.ms/new-console-template for more information
//string ,int ,float,double,bool;



using System.ComponentModel;


int sayi1;
int sayi2;
double sonuc;

Console.WriteLine("Sayı biri giriniz.");
sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("Sayı ikiyi giriniz.");
sayi2 = int.Parse(Console.ReadLine());

sonuc = Math.Sqrt(sayi1 * sayi2);
Console.WriteLine($"Sonuç : {sonuc}");


