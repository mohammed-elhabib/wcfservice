﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wcfservice.db;

namespace wcfservice.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "User" in both code and config file together.
    public class User : IUser
    {
        public void add()
        {
            testEntities entities = new testEntities();
            entities.users.Add(new user() { name = 1 });
            entities.users.Add(new user() { name = 3 });
            entities.users.Add(new user() { name = 2 });
            entities.SaveChanges();

                }
    }
}
