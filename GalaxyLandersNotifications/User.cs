﻿using Realms;

namespace GalaxyLandersNotifications
{
    class User : RealmObject
    {
        public string Name { get; set; }
        public string Token { get; set; }
    }
}