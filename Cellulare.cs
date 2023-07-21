using System;
using System.Collections.Generic;
using System.Text;

namespace Cell
{
    class Cellulare
    {
        public Batteria batt = new Batteria(500,100);
        public string nome;
        public Cellulare(Batteria batt, string nome)
        {
            this.nome = nome;
            this.batt = batt;
        }
        public int sms(Cellulare dest)
        {
            batt._risorsebatt = batt._risorsebatt - 1;
            dest.batt._risorsebatt = dest.batt._risorsebatt - 1;
            Console.WriteLine("Unita rimanenti a " + nome + ": " + batt._risorsebatt);
            return batt._risorsebatt;
        }
        public int chiama(int tempoinsec, Cellulare dest)
        {
            tempoinsec = tempoinsec / 5;
            batt._risorsebatt = batt._risorsebatt - tempoinsec;
            dest.batt._risorsebatt = dest.batt._risorsebatt - tempoinsec;
            Console.WriteLine("Unita rimanenti a " + nome + ": " + batt._risorsebatt);
            return batt._risorsebatt;
        }

    }
}
