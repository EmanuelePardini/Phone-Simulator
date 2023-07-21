using System;
using Cell;
namespace EsercizioClassi
{
    class Program
    {
        public static Cellulare DefinizioneCellulare()
        {
            int capienzabatt;
            int percentualebatt;
            string nome;
            Console.WriteLine("Inserire capienza e percentuale della batteria del cellulare");
            capienzabatt = Convert.ToInt32(Console.ReadLine());
            percentualebatt = Convert.ToInt32(Console.ReadLine());
            Batteria batt = new Batteria(capienzabatt, percentualebatt);
            Console.WriteLine("Inserire nome del proprietario");
            nome = Console.ReadLine();
            Cellulare cell = new Cellulare(batt,nome);
            return cell;
        }
        static void Main(string[] args)
        {
            Cellulare mio,tuo;
            mio=DefinizioneCellulare();
            tuo=DefinizioneCellulare();
            mio.chiama(120,tuo);
            tuo.sms(mio);
            tuo.sms(mio);
            mio.sms(tuo);
            tuo.chiama(45, mio);
            mio.chiama(3600, tuo);
            mio.batt.livellocarica();
            tuo.batt.livellocarica();
        }
    }
}
