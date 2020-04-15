using System;
using System.Collections.Generic;
using System.Text;

namespace KWProjects.Infrastructure.Domain.Entities
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
