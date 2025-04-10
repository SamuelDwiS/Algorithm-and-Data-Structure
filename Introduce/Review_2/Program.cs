using System;

namespace Review_Dua
{
public class Review_2
{
    public static void Main(string[] args)
    {
    
    string firstname, lastname, username, inputanusername;
    Console.WriteLine("Masukan Nama Depan :");
    firstname = Console.ReadLine();

    Console.WriteLine("Masukan Nama Belakang :");
    lastname = Console.ReadLine();

    username = firstname;

    Console.WriteLine("Masukan Nama Anda :");
    inputanusername = Console.ReadLine();

    if (string.Compare(username, inputanusername, true) == 0)
    {
        Console.WriteLine("Username anda benar");
    }
    else
    {
        Console.WriteLine("Username anda salah");
    }
        }
    }
}