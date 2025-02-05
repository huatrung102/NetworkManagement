﻿using Network.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Core.Interfaces
{
    public interface IContractService : IBaseService<Contract,Guid>
    {
        bool UpdateWithChilds(Contract entityToUpdate, HashSet<Type> childTypes);
    }
}
