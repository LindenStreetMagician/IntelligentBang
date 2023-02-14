using System;

namespace IntelligentBang.Models
{
    public class TopicModel
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string TopicName { get; set; }
    }
}
