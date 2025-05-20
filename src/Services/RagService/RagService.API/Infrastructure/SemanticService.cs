//namespace RagAgent.Infrastructure;

//public class SemanticService : ISemanticService
//{
//    private readonly ISemanticTextMemory _memory;

//    public SemanticService(ISemanticTextMemory memory)
//    {
//        _memory = memory;
//    }

//    public async Task SaveAsync(string subject, string text, string id, Dictionary<string, string>? metadata = null)
//    {
//        await _memory.SaveAsync(
//            collection: subject,
//            text: text,
//            id: id,
//            description: metadata != null ? System.Text.Json.JsonSerializer.Serialize(metadata) : null
//        );
//    }

//    public async Task<IList<MemoryQueryResult>> SearchAsync(string subject, string query, int limit = 5)
//    {
//        return await _memory.SearchAsync(subject, query, limit).ToListAsync();
//    }
//}
