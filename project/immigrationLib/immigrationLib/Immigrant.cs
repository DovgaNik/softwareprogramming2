namespace immigrationLib
{
    public class Immigrant
    {
        private string name;
        private DateTime dOB;
        private int pOB;
        private int citizenship;
        private string pIN;

        public Immigrant (string name, DateTime dOB, int pOB, int citizenship, string pIN)
        {
            Name = name;
            DOB = dOB;
            POB = pOB;
            Citizenship = citizenship;
            PIN = pIN;
        }

        public string Name { get => name; set => name = value; }
        public DateTime DOB { get => dOB; set => dOB = value; }
        public int POB { get => pOB; set => pOB = value; }
        public int Citizenship { get => citizenship; set => citizenship = value; }
        public string PIN { get => pIN; set => pIN = value; }

        public override string ToString()
        {
            return $"{name} born on {dOB.ToString("dd/MM/yyyy")} in {Countries.countries[pOB]} holding citizenship of {Countries.countries[citizenship]} with PIN of {pIN}";
        }

    }
}
