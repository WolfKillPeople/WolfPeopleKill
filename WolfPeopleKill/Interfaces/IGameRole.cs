﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WolfPeopleKill.DBModels;
using WolfPeopleKill.Models;

namespace WolfPeopleKill.Interfaces
{
    public interface IGameRole
    {
        public void PushGetRoles(IEnumerable<Models.GamePlay> data);

    }
}
