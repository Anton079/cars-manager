using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_manager
{
    public class UserService
    {
        private List<User> _UserS;

        public UserService()
        {
            _UserS = new List<User>();
            this.LoadData();
        }

        public void LoadData()
        {
            User User1 = new User("1", "rares@yahoo.com", "ghndg", 07457657);
            User User2 = new User("2", "radu@gmail.com", "gdnjhcgn", 0775675);
            User User3 = new User("3", "antonia@gmail.com", "sryjtrr", 0765756);
            User User4 = new User("4", "marius@gmail.com", "yhdw", 07675675);
            User User5 = new User("5", "beatrice@gmail.com", "dtyhd", 07485684);

            this._UserS.Add(User1);
            this._UserS.Add(User2);
            this._UserS.Add(User3);
            this._UserS.Add(User4);
            this._UserS.Add(User5);
        }

        public void AfisareUser()
        {
            foreach (User x in _UserS)
            {
                Console.WriteLine(x.UserInfo());
            }
        }
    }
}
