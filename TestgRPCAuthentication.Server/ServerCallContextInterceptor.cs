using System;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Core.Utils;

namespace TestgRPCAuthentication.ServerService
{
    // The interceptor invokes the registered callback on every RPC
// and passes the context value of the current call to it
class ServerCallContextInterceptor : Interceptor
{
    readonly Action<ServerCallContext> interceptor;

    public ServerCallContextInterceptor(Action<ServerCallContext> interceptor)
    {
        GrpcPreconditions.CheckNotNull(interceptor, nameof(interceptor));
        this.interceptor = interceptor;
    }

    public override Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
    {
        interceptor(context);
        context.RequestHeaders.Select(x => $"{x.Key}:{x.Value}").ToList<string>().ForEach(x => Console.WriteLine("{0}\t", x));
        return continuation(request, context);
    }   

    public override Task<TResponse> ClientStreamingServerHandler<TRequest, TResponse>(IAsyncStreamReader<TRequest> requestStream, ServerCallContext context, ClientStreamingServerMethod<TRequest, TResponse> continuation)
    {
        interceptor(context);
        return continuation(requestStream, context);
    }

    public override Task ServerStreamingServerHandler<TRequest, TResponse>(TRequest request, IServerStreamWriter<TResponse> responseStream, ServerCallContext context, ServerStreamingServerMethod<TRequest, TResponse> continuation)
    {
        interceptor(context);
        return continuation(request, responseStream, context);
    }

    public override Task DuplexStreamingServerHandler<TRequest, TResponse>(IAsyncStreamReader<TRequest> requestStream, IServerStreamWriter<TResponse> responseStream, ServerCallContext context, DuplexStreamingServerMethod<TRequest, TResponse> continuation)
    {
        interceptor(context);
        return continuation(requestStream, responseStream, context);
    }
}
}