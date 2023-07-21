using System;
using System.Collections.Generic;
using System.Text;

namespace Cell
{
    class Batteria
    {
        public int _capienzabatt;
        public int _risorsebatt;
        public int _percentualebatt;
        public Batteria(int cb, int pb)
        {
            _capienzabatt = cb;
            _percentualebatt = pb;
            _risorsebatt = _capienzabatt;
            eccezionicarica();
        }
        public void livellocarica()
        {
            _percentualebatt = (_risorsebatt * _percentualebatt) / _capienzabatt;
            eccezionicarica();
            Console.WriteLine("La percentuale della batteria è al " + _percentualebatt + "%");
        }
        private void eccezionicarica()
        {
            if (_percentualebatt < 1)
                throw new Exception("Batteria scarica!");
            if (_percentualebatt > 100)
                throw new Exception("Valore invalido!");
            if (_capienzabatt < 500)
                throw new Exception("Capienza batteria troppo piccola!");
            if (_capienzabatt > 6000)
                throw new Exception("Capienza batteria troppo grande!");
        }
    }
}
