﻿namespace Netflix.Domain.Models.UserContext
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string PlanId { get; set; }
    }
}
