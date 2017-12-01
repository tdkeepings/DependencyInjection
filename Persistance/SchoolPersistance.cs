using System;
using System.Collections.Generic;
using Models;

namespace Persistance {

    // In implementing IPersistable, we can now choose how SchoolPersistance will actually 
    // persist the data. Usually this is in a database or some file somewhere, but in this case
    // we can just stuff it into a list in memory
    public class SchoolPersistance : IPersistable<School> {
        private IEnumerable<School> schools;
        
        public IEnumerable<School> Data {
            get {
                return schools;
            }

            set {
                schools = value;
            }
        }

        public int Save() {
            // We can decide what "save" means in this case. Throw it into a file, a table, blob storage, whatever.
            
            /*
             *  foreach (School school in Data) {
                     // do something to this school...
                }
             */

            return 1;
        }
    }
}
