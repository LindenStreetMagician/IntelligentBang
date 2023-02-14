using System;

namespace IntelligentBang.Models
{
    public class ContestantModel
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string ContestantName { get; set; }
    }
}
