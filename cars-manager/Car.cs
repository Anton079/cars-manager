using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cars_manager
{

    public class Car
    {
        private int _id;
        private string _modelMasina;
        private int _greutatea;
        private int _putere;
        private int _inaltimea;
        private bool _disponibila;

        public Car(int id, string modelMasina, int greutate, int putere, int inaltime, bool disponibila)
        {
            Id = id;
            ModelMasina = modelMasina;
            Greutatea = greutate;
            Putere = putere;
            Inaltime = inaltime;
            Disponibila = disponibila;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ModelMasina
        {
            get { return _modelMasina; }
            set { _modelMasina = value;}
        }

        public int Greutatea
        {
            get { return _greutatea;}
            set { _greutatea = value;}
        }

        public int Putere
        {
            get { return _putere;}
            set { _putere = value;}
        }

        public int Inaltime
        {
            get { return _inaltimea;}
            set { _inaltimea = value;}
        }

        public bool Disponibila
        {
            get { return _disponibila; }
            set { _disponibila = value; }
        }

        public string CarInfo()
        {
            string text = " ";
            text += "Id ul" + Id + "\n";
            text += "Model masina " + ModelMasina + "\n";
            text += "Putere " + Putere + "\n";
            text += "Inaltime " + Inaltime + "\n";
            text += "Disponibila " + Disponibila + "\n";
            return text;
        }
    }

}
