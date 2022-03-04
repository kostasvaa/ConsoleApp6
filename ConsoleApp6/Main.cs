namespace Paskaita1
{

    class matematika
    {
        static void Main(string[] args)
        {
            Paskaita2.Matematika myObj = new Paskaita2.Matematika();
            myObj.Seka(); //Bus iskviestas sekos apskaiciavimo metodas

            myObj.setFakt(5); //Bus nustatytas skaicius faktorialo skaiciavimui
            myObj.Faktor();

            myObj.end = DateTime.Now;
            TimeSpan laikas = (myObj.end - myObj.start);

            Console.WriteLine("\n Programos skaiciavimas uztruko: " + laikas.TotalMilliseconds + "ms");

            Console.ReadLine();
        }
    }
}