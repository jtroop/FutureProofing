using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PeopleRepository
    {
        public List<Person> GetPeople()
        {
            var people = new List<Person> {
                new Person() {FirstName="John", LastName="Koeing", StartDate=DateTime.Parse("10/17/1975"), Rating=0 },
                new Person() {FirstName="Dylan", LastName="Hunt", StartDate=DateTime.Parse("10/02/2000"), Rating=0 },
                new Person() {FirstName="John", LastName="Crighton", StartDate=DateTime.Parse("03/19/1999"), Rating=0 },
                new Person() {FirstName="Dave", LastName="Lister", StartDate=DateTime.Parse("02/15/1998"), Rating=0 },
                new Person() {FirstName="John", LastName="Sheridan", StartDate=DateTime.Parse("01/26/1994"), Rating=0 },
                new Person() {FirstName="Dante", LastName="Montanna", StartDate=DateTime.Parse("11/01/2000"), Rating=0 },
                new Person() {FirstName="Issac", LastName="Gampu", StartDate=DateTime.Parse("09/10/1977"), Rating=0 }
            };
            return people;
        }
    }
}
