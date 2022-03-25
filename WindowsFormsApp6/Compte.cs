using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Compte
    {
        private int _id_perso;
        private string _role;
        private string _nom;

        public int ID_Perso
        {
            get => _id_perso;
            set => _id_perso = value;
        }
        public string Role
        {
            get => _role;
            set => _role = value;
        }
        public string Nom
        {
            get => _nom;
            set => _nom = value;
        }
    }
}
