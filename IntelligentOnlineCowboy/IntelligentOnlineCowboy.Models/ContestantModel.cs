using System;

namespace IntelligentOnlineCowboy.Models
{
    public class ContestantModel
    {
        public Guid Id { get; } = new Guid();
        public string Name { get; set; }
    }
}
