using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    #region Первое Задание 
    class Dengi
    {
        public int dollar { get; set; }
        public int dolar_cent { get; set; }
        public int evro { get; set; }
        public int evro_cent { get; set; }
        public int grivna { get; set; }
        public int copeyka { get; set; }
        public Dengi(int Dollar, int Dollar_Cent, int Euro, int Euro_Cent, int Grivna, int Copeyka)
        {
            dollar = Dollar;
            dolar_cent = Dollar_Cent;
            evro = Euro;
            evro_cent = Euro_Cent;
            grivna = Grivna;
            copeyka = Copeyka;
        }
        public Dengi() : this(0, 0, 0, 0, 0, 0) { }
        public void Print()
        {
            Console.WriteLine($"{dollar}.{dolar_cent} Долар \n{evro}.{evro_cent}  Евро \n{grivna}.{copeyka} Гривны ");
        }
    }
    class Product : Dengi
    {
        public int Cena { get; set; }
        public int Cena_Cent { get; set; }
        public Product(int cena, int cena_cent, int Dollar, int Dollar_Cent, int Euro, int Euro_Cent, int Grivna, int Copeyka)
            : base(Dollar, Dollar_Cent, Euro, Euro_Cent, Grivna, Copeyka)
        {
            Cena = cena;
            Cena_Cent = cena_cent;
        }
        public Product(int cena, int cena_cent)
        {
            Cena = cena;
            Cena_Cent = cena_cent;
        }
        public Product() : this(0, 0, 0, 0, 0, 0, 0, 0) { }
        public void PokupkaDollara()
        {
            base.dollar -= Cena;
            base.dolar_cent -= Cena_Cent;
        }
        public void PokupkaEvro()
        {
            base.evro -= Cena;
            base.evro_cent -= Cena_Cent;
        }
        public void PokuokaGrivni()
        {
            base.grivna -= Cena;
            base.copeyka -= Cena_Cent;
        }
    }
    #endregion
    #region Второе задание :
    class Ysrtoistvo
    {
        public string Imya { get; set; }
        public string Musika { get; set; }
        public string Opicanie { get; set; }
        public Ysrtoistvo(string imya, string musika, string opicanie)
        {
            Imya = imya;
            Musika = musika;
            Opicanie = opicanie;
        }
        public Ysrtoistvo() : this("", "", "") { }
        public void Print()
        {
            Console.WriteLine($"Device  {Imya}, Sound {Musika}, Opicanie {Opicanie}");
        }
    }
    class Chainik : Ysrtoistvo
    {
        public Chainik(string imya, string musika, string opicanie) : base(imya, musika, opicanie) { }
        public Chainik() : base("Kettle", "Whistling", "For water heating") { }

    }
    class Microlownovka : Ysrtoistvo
    {
        public Microlownovka(string imya, string musika, string opicanie) : base(imya, musika, opicanie) { }
        public Microlownovka() : base("Microlownovka", "micro noise", "For heating food") { }
    }
    class Avtomobil : Ysrtoistvo
    {
        public Avtomobil(string imya, string musika, string opicanie) : base(imya, musika, opicanie) { }
        public Avtomobil() : base("Avtomobil", "Work carburet, diesel engine", "For driving on roads") { }
    }
    class Paraxod : Ysrtoistvo
    {
        public Paraxod(string imya, string musika, string opicanie) : base(imya, musika, opicanie) { }
        public Paraxod() : base("Paraxod", "Steam engine operation", "To ride on rails") { }
    }
    #endregion
    #region Третье Задание
    class Zvuk
    {
        public string Imya { get; set; }
        public string Opicanie { get; set; }
        public string Sound { get; set; }
        public string Istoriya { get; set; }
        public Zvuk(string imya, string opicanie, string zvuk, string istoriya)
        {
            Imya = imya;
            Opicanie = opicanie;
            Sound = zvuk;
            Istoriya = istoriya;
        }
        public Zvuk() : this("", "", "", "") { }
        public void Print()
        {
            Console.WriteLine($" Imya   {Imya}\n Opicanie  {Opicanie}\n Zvuk  {Sound}\n Istoriya {Istoriya}");
        }
    }
    class Skripka : Zvuk
    {
        public Skripka() : base("Skripka", "Orchestra", "Creak", "14 century") { }
        public Skripka(string imya, string opicanie, string zvuk, string istoriya) : base(imya, opicanie, zvuk, istoriya) { }
    }
    class Trombon : Zvuk
    {
        public Trombon() : base("Trombone", "Orchestra", "Horn", "14 century") { }
        public Trombon(string imya, string opicanie, string zvuk, string istoriya) : base(imya, opicanie, zvuk, istoriya) { }
    }
    class Ukulele : Zvuk
    {
        public Ukulele() : base("Ukulele", "Guitar", "String", "18 century") { }
        public Ukulele(string imya, string opicanie, string zvuk, string istoriya) : base(imya, opicanie, zvuk, istoriya) { }
    }
    class Violonchel : Zvuk
    {
        public Violonchel() : base("Cello", "Orchestra", "Creak", "17 century") { }
        public Violonchel(string imya, string opicanie, string zvuk, string istoriya) : base(imya, opicanie, zvuk, istoriya) { }
    }
    #endregion
    #region Четвертое задание 
    abstract class Rabotnik
    {
        virtual public void Print() { }
    }
    class President : Rabotnik
    {
        public string Imya { get; set; }
        public string Opicanie { get; set; }
        public President(string imya, string opicanie)
        {
            Imya = imya;
            Opicanie = opicanie;
        }
        public override void Print()
        {
            Console.WriteLine($"Imya  {Imya}\n Opicanie  {Opicanie}");
        }
    }
    class Oxrana : Rabotnik
    {
        public string Imya { get; set; }
        public string Opicanie { get; set; }
        public Oxrana(string imya, string opicanie)
        {
            Imya = imya;
            Opicanie = opicanie;
        }
        public override void Print()
        {
            Console.WriteLine($"Imya {Imya}\n Opicanie {Opicanie}");
        }
    }
    class Meneger : Rabotnik
    {
        public string Imya { get; set; }
        public string Opicanie { get; set; }
        public Meneger(string imya, string opicanie)
        {
            Imya = imya;
            Opicanie = opicanie;
        }
        public override void Print()
        {
            Console.WriteLine($"Imya {Imya} \n Opicanie {Opicanie}");
        }
    }
    class Enginer : Rabotnik
    {
        public string Imya { get; set; }
        public string Opicanie { get; set; }
        public Enginer(string imya, string opicanie)
        {
            Imya = imya;
            Opicanie = opicanie; ;
        }
        public override void Print()
        {
            Console.WriteLine($"Imya {Imya} \n Opicanie {Opicanie}");
        }
    }
    #endregion
}