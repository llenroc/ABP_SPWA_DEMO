using Abp.Domain.Entities;
namespace SPWA.People
{
    public class Person : Entity
    {
        public virtual string Name { get; set; }

        public virtual int? Age { get; set; }
    }
}