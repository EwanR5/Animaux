using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaux
{
    internal class Chien
    {
        private string _nom;
        private string _race;
        private uint _age;
        private bool _vaccin;

        public Chien(string nom, string race, uint age)
        {
            _nom = nom;
            _race = race;
            _age = age;
        }

        public uint Nom
        {
            get { return _nom; }
        }
        public uint Race
        {
            get { return _race; }
        }
        public uint Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public bool Vaccin
        {
            get { return _vaccin; }
            set { _vaccin = !value; }
        }

        public string RecupereCaracteristiques()
        {
            string chaine = "Nom : " + _nom + " \n Race : " + _race + "\n Age : " + _age "\n Vacciné : " + _vaccin;
            return chaine;
        }
    }
}
