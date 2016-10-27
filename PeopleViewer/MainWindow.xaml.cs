using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PersonLibrary;
using System.Collections;

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PeopleRepository peopleRepo = new PeopleRepository();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            List<Person> people;
            people = peopleRepo.GetPeople();
            foreach (var person in people)
            {
                PersonListBox.Items.Add($"{person.FirstName} {person.LastName} {person.Rating} {person.StartDate}");
            }
        }

        private void InterfaceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            // The big thing with this line is that we don't know what type this is 
            // it could be a list, array, collection, etc.
            // And we shouldn't care because since whatever this is implements IENumerable
            // this means we can iterate over it.
            // By adding the <Person> to IEnumberable we are strongly typing this 
            // so we can now all of the public properties and methods of the Person
            // class
            // Normally we wouldn't do all this foreach loop stuff, instead we would bind the PersonListBox
            // to a datasource, in this case peopleRepo.GetPeople();
            IEnumerable<Person> people;
            
            people = peopleRepo.GetPeople();
            PersonListBox.ItemsSource = people;
            
            
            //foreach (var person in people)
            //{
            //    PersonListBox.Items.Add($"{person.FirstName} {person.LastName} {person.Rating} {person.StartDate}");
            //}
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            //PersonListBox.Items.Clear();
            PersonListBox.ItemsSource = null;
        }
    }
}
