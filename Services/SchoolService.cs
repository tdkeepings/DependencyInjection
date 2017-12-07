using System;
using Models;
using Persistance;
using System.Linq;

namespace Services {
    public class SchoolService : ISchoolService {
        private IPersistable<School> _context;

        public SchoolService(IPersistable<School> context) {
            _context = context;
        }

        /// <summary>
        /// Implement the ISchoolService interface. 
        /// Returns the Top Student
        /// </summary>
        /// <returns></returns>
        public Student GetTopStudent() {
            return _context.Data.Students.First();
        }
    }
}
