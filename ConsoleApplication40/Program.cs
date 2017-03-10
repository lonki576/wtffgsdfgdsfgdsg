using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Teszt
    {
        static void Main(string[] args)
        {
            Burkoló a = new Burkoló("Tapéta_Lajos",60000,szakterületek.belső );
            Vízvezetékszerelő b = new Vízvezetékszerelő("Megszer ", 12000, 3);
            Burkoló c = new Burkoló("Vakolat Péter", 50000, szakterületek.külső);
            Vízvezetékszerelő d = new Vízvezetékszerelő(" Víz Elek", 15000 , 5);
            Burkoló e = new Burkoló("Eresz János", 30000,  szakterületek.külső);
            Vízvezetékszerelő f = new Vízvezetékszerelő(" Motherfucker john", 20000, 1);


        }
    }
}
