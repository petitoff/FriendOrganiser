﻿using FriendOrganiser.Model;
using System.Collections.Generic;

namespace FriendOrganiser.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: Load data from real database
            yield return new Friend { FirstName = "Thomas", LastName = "Huber" };
            yield return new Friend { FirstName = "Andres", LastName = "Huber" };
            yield return new Friend { FirstName = "Julia", LastName = "Huber" };
            yield return new Friend { FirstName = "Chrissi", LastName = "Huber" };
        }
    }
}
