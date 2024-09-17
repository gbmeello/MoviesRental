using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRental.Core.DomainObjects
{
    public class Entity
    {

        public Entity()
        {
            Id = Guid.NewGuid();
            CreateAt = DateTime.Now;

        }
        public Guid Id { get; protected set; }
        public DateTime CreateAt { get; protected set; }
        public DateTime UpdateAt { get; protected set; }
        public DateTime? DeleteAt { get; protected set; }

    }
}
