﻿using MySql.Data.MySqlClient;

namespace Rasa.Structures
{
    public class NPCPackagesEntry
    {
        public uint CreatureDbId { get; set; }
        public int NpcPackageId { get; set; }

        public static NPCPackagesEntry Read(MySqlDataReader reader)
        {
            return new NPCPackagesEntry
            {
                CreatureDbId = reader.GetUInt32("creatureDbId"),
                NpcPackageId = reader.GetInt32("packageId")
            };
        }
    }
}