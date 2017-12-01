using System.Collections.Generic;

namespace Models {
    public class School {
        public string Name { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
