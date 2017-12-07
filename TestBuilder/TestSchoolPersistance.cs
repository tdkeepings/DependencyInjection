using Models;
using Persistance;
using System;
using System.Collections.Generic;

namespace TestBuilder {
    public class TestSchoolPersistance : IPersistable<School> {
        private School school = new School() {
            Name = "My Test School",
            Students = new List<Student>() {
                new Student() {
                    Name = "Test Student",
                    DateOfBirth = new DateTime(1,1,1)

                }
            }
        };

        public School Data {
            get {
                return school;
            }

            set {
                school = value;
            }
        }

        public int Save() {
            return 1;
        }
    }
}
