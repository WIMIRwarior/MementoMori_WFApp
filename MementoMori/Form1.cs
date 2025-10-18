namespace MementoMori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<string, double> LifetimeExpentancy = new Dictionary<string, double>
        {
                {   "Albania" ,   79.1    }   ,
                {   "Austria" ,   81.5    }   ,
                {   "Belarus" ,   74.4    }   ,
                {   "Belgium" ,   82.5    }   ,
                {   "Bosnia and Herzegovina"  ,   77.9    }   ,
                {   "Bulgaria"    ,   75.8    }   ,
                {   "Croatia" ,   78.6    }   ,
                {   "Cyprus"  ,   82.5    }   ,
                {   "Czechia" ,   80.0    }   ,
                {   "Denmark" ,   81.9    }   ,
                {   "Estonia" ,   78.8    }   ,
                {   "Finland" ,   81.7    }   ,
                {   "France"  ,   83.1    }   ,
                {   "Germany" ,   81.2    }   ,
                {   "Greece"  ,   81.6    }   ,
                {   "Hungary" ,   76.9    }   ,
                {   "Iceland" ,   82.6    }   ,
                {   "Ireland" ,   82.6    }   ,
                {   "Italy"   ,   83.8    }   ,
                {   "Kosovo"  ,   78.0    }   ,
                {   "Latvia"  ,   75.9    }   ,
                {   "Liechtenstein"   ,   84.8    }   ,
                {   "Lithuania"   ,   77.3    }   ,
                {   "Luxembourg"  ,   83.4    }   ,
                {   "Malta"   ,   83.6    }   ,
                {   "Moldova" ,   71.2    }   ,
                {   "Montenegro"  ,   73.8    }   ,
                {   "Netherlands" ,   82.0    }   ,
                {   "North Macedonia" ,   73.2    }   ,
                {   "Norway"  ,   83.1    }   ,
                {   "Poland"  ,   78.6    }   ,
                {   "Portugal"    ,   82.4    }   ,
                {   "Romania" ,   76.6    }   ,
                {   "Russia"  ,   73.2    }   ,
                {   "Serbia"  ,   75.2    }   ,
                {   "Slovakia"    ,   78.1    }   ,
                {   "Slovenia"    ,   82.0    }   ,
                {   "Spain"   ,   84.0    }   ,
                {   "Sweden"  ,   83.4    }   ,
                {   "Switzerland" ,   84.2    }   ,
                {   "Ukraine" ,   73.4    }   ,
                {   "United Kingdom"  ,   81.3    }
            };

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_Country.SelectedItem != null)
            {
                string selectedItem = comboBox_Country.SelectedItem.ToString();
                double lifetimeExpentacyForChoosenCountry = LifetimeExpentancy[selectedItem];
                int calculated_age = CalculateAge();
                double lifetimeLeft = lifetimeExpentacyForChoosenCountry - calculated_age;

                if (calculated_age > 0)
                {
                    if (lifetimeLeft > 0)
                    {
                        MessageBox.Show("Statistic lifetime expentacy for " + selectedItem + " is approx. " +
                                        lifetimeExpentacyForChoosenCountry + " years.\nYou are " + $"{calculated_age:F0}" + " years old.\nSo you have technicaly " + lifetimeLeft +
                                        " years left.\n Use it wisely :) ");
                    }
                    else
                    {
                        MessageBox.Show("Statistic lifetime expentacy for " + selectedItem + " is approx. " +
                                       lifetimeExpentacyForChoosenCountry + " years.\nYou are " + $"{calculated_age:F0}" + " years old.\nSo technicaly You should be dead :) ");
                    }
                }
                if(calculated_age==0)
                {
                    MessageBox.Show("Statistic lifetime expentacy for " + selectedItem + " is approx. " +
                                        lifetimeExpentacyForChoosenCountry + " years.\nYou just have been born so you have technicaly You have " + lifetimeLeft +
                                        " years left.\nUse it wisely Kid :) ");
                }
            }
            else
            {
                MessageBox.Show("Country check ERROR!");
            }
        }

        private int CalculateAge()
        {
            int age = 0;
            if (dtp_CurrentDate.Value > dtp_DayOfBirth.Value)
            {
                age = dtp_CurrentDate.Value.Year - dtp_DayOfBirth.Value.Year;
                if ( (age + dtp_DayOfBirth.Value.Year) < dtp_CurrentDate.Value.Year)
                {
                    age--;
                }
            }
            else
            {
                MessageBox.Show("Current date can't be erlier than day of birth!");
                return -1;
            }
            return age;
        }
    }
}
