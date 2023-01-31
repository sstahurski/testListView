using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace testNoShell
{
    public class Person 
    {
        public string Name { get; set; }

        public Person()
        {
        }
    }

    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private ObservableCollection<Person> persons = new ObservableCollection<Person>();
        public ObservableCollection<Person> Persons
        {
            get { return persons; }
            set
            {
                persons = value;
            }
        }

        public MainPageViewModel()
        {

            string[] names = { "Billy", "Jim", "Joe", "Bob", "Scott", "Keith", "Cory", "Bode", "Don", "Richard", "Tyler", "Mason", "Antony", "Harold", "Lowell", "Loyd", "Morton", "Jesse" };

            foreach (string name in names) {
                persons.Add(new Person() { Name = name });
            }

            foreach (string name in names)
            {
                persons.Add(new Person() { Name = name });
            }
        }


    }
}

