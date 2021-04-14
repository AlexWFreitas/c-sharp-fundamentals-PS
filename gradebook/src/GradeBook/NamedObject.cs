using System;

namespace GradeBook
{
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }
        public virtual string Name
        {
            get;
            set;
        }
    }
}
