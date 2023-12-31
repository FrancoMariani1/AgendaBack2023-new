﻿using AgendaBack2023.Entities;

namespace AgendaBack2023.Models.DTO
{
    public class ContactDTO
    {
        public string name { get; set; }
        public string? lastName { get; set; }
        public string? avatar { get; set; }
        public string? description { get; set; }
        public string? email { get; set; }
        public long celularNumber { get; set; }
        public long? telephoneNumber { get; set; }

        public LocationDTO? location { get; set; }
    }
}
