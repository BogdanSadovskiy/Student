

namespace Myspace
{
    interface IdDateBaseOperation
    {

        void Insert(Student student);
        void Update(Student student, string Name);
        void Delete(Student student);
        Student Select(int ID);

    }
}
