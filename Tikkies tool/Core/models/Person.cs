﻿using System;
using System.Collections.Generic;
using System.Text;

namespace core.models
{
    public class Person
    {
        public string Name { get; private set; }
        public double AmmountPaid { get; private set; }
        public List<Transaction> TransactionsMade { get; private set; }
    }
}
