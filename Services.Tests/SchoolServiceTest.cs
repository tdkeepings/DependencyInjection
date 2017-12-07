using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Persistance;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using TestBuilder;

namespace Services.Tests {
    [TestClass]
    public class SchoolServiceTest {

        private static IPersistable<School> testSchoolPersistance;
        private static ISchoolService service;

        [ClassInitialize]
        public static void Init(TestContext context) {
            testSchoolPersistance = new TestSchoolPersistance();
            service = new SchoolService(testSchoolPersistance);
        }

        [TestMethod]
        public void GetTopPerformer() {
            //Arrange
            Student student;

            //Act
            student = service.GetTopStudent();

            //Assert
            Assert.AreEqual(student.Name, "Test Student", "The reported top performing student is incorrect");
        }   
    }
}
