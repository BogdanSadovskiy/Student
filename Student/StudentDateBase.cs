

namespace Myspace
{
    class StudentDateBase : IdDateBaseOperation
    {
        private List<Student> _students = new List<Student>();
        public void Delete(Student student)
        {
            _students.Remove(student);
        }

        public void Insert(Student student)
        {
            _students.Add(student);
        }

        public Student Select(int ID)
        {
            foreach (Student student in _students)
            {
                if (student.ID == ID)
                {
                    return student;
                }
            }
            return null;
        }

        public void Update(Student student, string Name)
        {
            student.Name = Name;
        }
    }
}
