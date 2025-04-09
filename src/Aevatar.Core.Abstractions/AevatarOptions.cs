namespace Aevatar.Core.Abstractions;

public class AevatarOptions
{
    public string StreamNamespace { get; } = "grain-stream-topic";
    public string ProjectorStreamNamespace { get; } = "projector-stream-topic";
    //public int ElasticSearchProcessors { get; set; } = 10;
}