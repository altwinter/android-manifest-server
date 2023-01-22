using Grpc.Core;
using GrpcManifestParser;

namespace GrpcManifestParser.Services;

public class ManifestParserService : ManifestParser.ManifestParserBase
{
    private readonly ILogger<ManifestParserService> _logger;
    public ManifestParserService(ILogger<ManifestParserService> logger)
    {
        _logger = logger;
    }

    public override Task<ParseReply> ParseData(ManifestInfo request, ServerCallContext context)
    {
        try
        {
            AndroidParser.ManifestToJson(request.ManifestPath, request.ApkPath);

            return Task.FromResult(new ParseReply
            {
                Response = true,
                Message = ""
            });
        }
        catch (System.Exception exp)
        {

            // throw;
            // exp; save to Error message

            return Task.FromResult(new ParseReply
            {
                Response = false,
                Message = exp.ToString()
            });
        }
    }
}



