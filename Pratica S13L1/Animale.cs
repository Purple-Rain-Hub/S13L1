
namespace Pratica_S13L1
{
    public class Animale
    {
        private string _name;
        private string _species;
        private int _age;

        public string Name{
            get
            {
                return _name;
            }
            set {
            _name = value;
            }
        }
        public string Species
        {
            get
            {
                return _species;
            }
            set
            {
                _species = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

    }
}
