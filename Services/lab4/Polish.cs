using Lab1.Services.lab4.Lang;

namespace Lab1.Services.lab4
{
    public class Polish : Language, ILanguage
    {
        public Polish(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public override string getLang()
        {
            return Name;
        }
        public string GetLanguageName()
        {
            return Name;
        }
    }

       
    }

