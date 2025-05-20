//using RagAgent.Infrastructure;

namespace RagAgent.API.Extensions;

public static class Extensions
{
    public static void AddApiServices(this IHostApplicationBuilder builder)
    {
        //builder.Services.AddSingleton<IMemoryStore>(provider =>
        //{
        //    var logger = provider.GetRequiredService<ILoggerFactory>();
        //    return new QdrantMemoryStore("http://localhost:6333", "", logger);
        //});

        //builder.Services.AddSingleton<ISemanticTextMemory>(provider =>
        //{
        //    var memoryStore = provider.GetRequiredService<IMemoryStore>();
        //    var embedding = new OpenAITextEmbeddingGeneration("your-model", "your-api-key"); // یا هر embedding service دلخواه
        //    return new SemanticTextMemory(memoryStore, embedding);
        //});

        //builder.Services.AddScoped<SemanticService>();

    }

}
