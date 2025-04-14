
using Amazon.Lambda.Core;
using System.Threading.Tasks;
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloWorld;

public class Function
{
    public async Task<string> FunctionHandler(ILambdaContext context)
    {
        return "Hello, World!";
    }
}

