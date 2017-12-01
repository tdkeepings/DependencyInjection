using System;
using System.Collections.Generic;
using Models;

namespace Persistance {
    // An alternative way that SchoolPersistance could be defined.
    public class SchoolDbPersistance : IPersistable<School> {
        private IDbContext<School> schoolContext;
        private IEnumerable<School> schools;

        // This is instanciatable with either "MyDbContext" or "MyOtherContext"
        // The code for which is at the bottom of this file.
        public SchoolDbPersistance(IDbContext<School> _context) {
            schoolContext = _context;
            schools = schoolContext.GetAll();
        }

        public IEnumerable<School> Data {
            get {
                return schools;
            }

            set {
                schools = value;
            }
        }

        public int Save() {
            return schoolContext.Save(Data);
        }
    }



    #region Boilerplate code to get the above working, completely throw away code
    public interface IDbContext<TEntity> {
        IEnumerable<TEntity> GetAll();
        int Save(IEnumerable<TEntity> data);
    }

    // An implementation of the IDbContext. This could exist along with several other imeplementations,
    // and all of them could be valid parameters/input for anything that expects an IDbContext<School> as
    // the parameter. 
    public class MyDbContext : IDbContext<School> {
        public IEnumerable<School> GetAll() {
            return new List<School>();
        }
        public int Save(IEnumerable<School> data) {
            // save the data somewhere special, like a database using a stored procedure
            // then return a sensible status code, say 1 is Success
            return 1;
        }
    }

    public class MyOtherContext : IDbContext<School> {
        public IEnumerable<School> GetAll() {
            return new List<School>();
        }
        public int Save(IEnumerable<School> data) {
            // save the data somewhere special, like a database using a stored procedure
            // then return a sensible status code, say 1 is Success
            return 1;
        }
    }

    #endregion
}
