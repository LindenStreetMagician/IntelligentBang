using System;

namespace IntelligentOnlineCowboy.Models
{
    public class ContestantModel
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
