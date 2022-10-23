using System;

namespace Oliotehtava_5
{
    class Opiskelija
    {

        //kentät
        private string nimi;
        private int ikä;
        private int arvosana;
        public static int opiskelijaMäärä = 0;

        //metodit
        public string muutaNimi()
        {
            Console.WriteLine("muutaNimi metodia käytetty");
            return nimi;
        }
        public int muutaArvosana()
        {
            Console.WriteLine("muutaArvosana metodia käytetty");
            arvosana = 4;
            return arvosana;
        }
        public int vanhene(int vuosi)
        {
            Console.WriteLine("vanhene metodia käytetty");
            ikä += vuosi;
            Console.WriteLine("Opiskelija {0} vanheni {1} vuotta ja on nyt {2} vuotias", nimi, vuosi, ikä);
            if (ikä >= 18)
            {
                Console.WriteLine("Opiskelija on täysi-ikäinen");
            }
            Console.WriteLine("");
            return ikä;
        }
        public string tulostaOpiskelijanTiedot()
        {
            Console.WriteLine("tulostaOpiskelijanTiedot metodia käytetty");
            Console.WriteLine("");
            Console.WriteLine(" opiskelija 1\n nimi: {0} \n ikä: {1} \n arvosana: {2}", nimi, ikä, arvosana);
            Console.WriteLine("");
            return nimi;
        }

        //oletuskonstruktori
        public Opiskelija()
        {
            nimi = "";
            ikä = 0;
            arvosana = 0;
            opiskelijaMäärä++;
            Console.WriteLine("oletuskonstruktoria käytetty");
        }

        //ylikuormitettu konstruktori
        public Opiskelija(string u_nimi, int u_ikä, int u_arvosana)
        {
            nimi = u_nimi;
            ikä = u_ikä;
            arvosana = u_arvosana;
            opiskelijaMäärä++;
            Console.WriteLine("Ylikuormitettua konstruktoria käytetty");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Oliotehtävä 4 / Otso Rantala");
            Console.WriteLine("");

            Opiskelija opiskelija1 = new Opiskelija("Otso", 18, 8);
            Console.WriteLine("opiskelija1 olio luotu");
            Console.WriteLine("");

            Console.WriteLine(" opiskelija 1\n nimi: {0} \n ikä: {1} \n arvosana: {2}", opiskelija1.nimi, opiskelija1.ikä, opiskelija1.arvosana);
            Console.WriteLine("");

            Opiskelija opiskelija2 = new Opiskelija("Alex", 17, 6);
            Console.WriteLine("opiskelija2 olio luotu");
            Console.WriteLine("");

            Console.WriteLine(" opiskelija 2\n nimi: {0} \n ikä: {1} \n arvosana: {2}", opiskelija2.nimi, opiskelija2.ikä, opiskelija2.arvosana);
            Console.WriteLine("");

            Opiskelija opiskelija3 = new Opiskelija("Essi", 19, 9);
            Console.WriteLine("opiskelija3 olio luotu");
            Console.WriteLine("");

            Console.WriteLine(" opiskelija 3\n nimi: {0} \n ikä: {1} \n arvosana: {2}", opiskelija3.nimi, opiskelija3.ikä, opiskelija3.arvosana);
            Console.WriteLine("");

            Opiskelija opiskelija4 = new Opiskelija("Anna", 16, 5);
            Console.WriteLine("opiskelija4 olio luotu");
            Console.WriteLine("");

            Console.WriteLine(" opiskelija 4\n nimi: {0} \n ikä: {1} \n arvosana: {2}", opiskelija4.nimi, opiskelija4.ikä, opiskelija4.arvosana);
            Console.WriteLine("");

            opiskelija1.vanhene(4);
            opiskelija2.vanhene(1);
            opiskelija3.vanhene(45);
            opiskelija4.vanhene(1);
            Console.WriteLine("");
            opiskelija1.muutaArvosana();
            opiskelija2.muutaArvosana();
            opiskelija3.muutaArvosana();
            opiskelija4.muutaArvosana();
            Console.WriteLine("");
            opiskelija1.tulostaOpiskelijanTiedot();
            opiskelija2.tulostaOpiskelijanTiedot();
            opiskelija3.tulostaOpiskelijanTiedot();
            opiskelija4.tulostaOpiskelijanTiedot();

            Console.WriteLine("");
            Console.WriteLine("Opiskelijoiden määrä: " + Opiskelija.opiskelijaMäärä);
        }
    }
}
