﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
