

namespace Student
{
    internal class IDCreator
    {
        private List<int> ids = new List<int>();
        public int createID()
        {
            int id = 100+ ids.Count()+1;
            ids.Add(id);
            return id;   
        }
    }
}
