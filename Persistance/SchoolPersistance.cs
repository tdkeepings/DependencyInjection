using System;
using System.Collections.Generic;
using Models;

namespace Persistance {

    // In implementing IPersistable, we can now choose how SchoolPersistance will actually 
    // persist the data. Usually this is in a database or some file somewhere, but in this case
    // we can just stuff it into memory
    public class SchoolPersistance : IPersistable<School> {
        private School school;
        
        public SchoolPersistance() {

            // NOTE: This kind of data population would not happen in a constructor. 
            // Instead it would remain in persistance somewhere; a file, database, blob storage etc.
            // This only has some boilerplate code to get the example working
            school = new School() {
                Name = "My school",
                Students = new List<Student>() {
                    new Student() {
                        Name = "Apple Crumble",
                        DateOfBirth = new DateTime(2000, 1, 1)
                    },
                    new Student() {
                        Name = "Banana Split",
                        DateOfBirth = new DateTime(1990, 5, 5)
                    }
                }
            };
        }

        public School Data {
            get {
                return school;
            }

            set {
                school = value;
            }
        }

        public int Save() {
            // We can decide what "save" means in this case. Throw it into a file, a table, blob storage, whatever.
            
            //foreach (School school in Data) {
            //    // do something to this school...
            //}

            return 1;
        }
    }
}
