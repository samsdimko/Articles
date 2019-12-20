using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp2
{
    class Person
    {
        [JsonProperty]
        private int id;
        [JsonProperty]
        private string Surname;
        [JsonProperty]
        private string Maiden_Name;
        [JsonProperty]
        private string Name;
        [JsonProperty]
        private string Patronymic;
        [JsonProperty]
        private string Birthday;
        [JsonProperty]
        private bool Birt = false;
        [JsonProperty]
        private string Place_of_birth;
        [JsonProperty]
        private string Date_of_death;
        [JsonProperty]
        private bool Death = false;
        [JsonProperty]
        private string Place_of_death;
        [JsonProperty]
        private string Nationality;
        [JsonProperty]
        private string Sosial;
        [JsonProperty]
        private string Educations;
        [JsonProperty]
        private string Proffesions;
        [JsonProperty]
        private string Address;
        [JsonProperty]
        private string From_ty;
        [JsonProperty]
        private string Source;
        [JsonProperty]
        private string Curriculum;
        [JsonProperty]
        private string Mother;
        [JsonProperty]
        private string Father;
        [JsonProperty]
        private int idF = -1;
        [JsonProperty]
        private int idM = -1;
        [JsonProperty]
        private List<int> idch = new List<int>();       
        static Person()
        {

        }
        [JsonConstructor]
        public Person(string Surname,
            string Maiden_Name,
            string Name,
            string Patronymic,
            string Birthday,
            string Birt,
            string Place_of_birth,
            string Date_of_death,
            string Death,
            string Place_of_death,
            string Nationality,
            string Sosial,
            string Educations,
            string Proffesions,
            string Address,
            string From_ty,
            string Source,
            string Curriculum,
            string Mother,
            string Father)
        {
            this.Surname = Surname;
            if (Maiden_Name != "-")
                this.Maiden_Name = Maiden_Name;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Birthday = Birthday;
            if (Birt == "yes")
                this.Birt = true;
            else
                this.Birt = false;
            this.Place_of_birth = Place_of_birth;
            this.Date_of_death = Date_of_death;
            if (Death == "yes")
                this.Death = true;
            else
                this.Death = false;
            this.Place_of_death = Place_of_death;
            this.Nationality = Nationality;
            this.Sosial = Sosial;
            this.Educations = Educations;
            this.Proffesions = Proffesions;
            this.Address = Address;
            this.From_ty = From_ty;
            this.Source = Source;
            this.Curriculum = Curriculum;
            this.Mother = Mother;
            this.Father = Father;
            id = Dataset.GetID();
            Dataset.DatasetAdd(this);
            //Dataset.RecreateDataset();
        }

        public string GetName()
        {
            return this.Surname + " " + this.Name + " " + this.Patronymic;
        }
        public bool GetName(string Name, string Surname, string Patronymic)
        {
            if (this.Name.Contains(Name) != false && (this.Surname.Contains(Surname) != false || this.Maiden_Name.Contains(Surname) != false) && this.Patronymic.Contains(Patronymic) != false)
                return true;
            else return false;
        }
        public bool GetBirthPlace(string Place_of_birth)
        {
            if (this.Place_of_birth.Contains(Place_of_birth) != false)
                return true;
            else return false;
        }
        public bool GetAddress(string Address)
        {
            if (this.Address.Contains(Address) != false)
            {
                return true;
            }
            return false;
        }
        public int Getid()
        {
            return id;
        }       
        public int GetFatherID()
        {
            return idF;
        }
        public int GetMotherID()
        {
            return idM;
        }
        public List<int> GetChildList()
        {
            return idch;
        }
    }
}
