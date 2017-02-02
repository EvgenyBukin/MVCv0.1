using Home.Domain.Entities;
using System.Collections.Generic;

namespace Home.Domain.Abstract
{
    public interface IGeneralRepository
    {
        IEnumerable<General> Generals { get; }
        void Save(General general);
        General Delete(int moduleId);
    }
}
