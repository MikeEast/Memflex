﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using FlexProviders.Raven;
using LogMeIn.Models;

namespace LogMeIn.Tests.Integration.Raven
{
    public class Role : IFlexRole<User>
    {
        public Role()
        {
            Users = new Collection<string>();
        }

        public string Name { get; set; }
        public ICollection<string> Users { get; set; }
    }
}