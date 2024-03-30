using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_manager
{
    public class Inchiriere
    {
        private int _id;
        private int _idUser;
        private int _idCar;

        public Inchiriere(int id, int idUser, int idCar)
        {
            _id = id;
            _idUser = idUser;
            _idCar = idCar;
        }

        public int Id 
        { 
            get { return _id; } 
            set { _id = value; }
        }

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        public int IdCar
        {
            get { return _idCar; }
            set { _idCar = value; }
        }

        public string InchiriereInfo()
        {
            string text = " ";
            text += "Idul" + Id + "\n";
            text += "Idul User " + IdUser + "\n";
            text += "Id Car" + IdCar + "\n";
            return text;
        }
    }
}
