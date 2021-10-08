using System;
using System.Threading;
using System.Threading.Tasks;

public static class AsyncToSync
{
    private static readonly TaskFactory taskFactory = new TaskFactory(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, TaskScheduler.Default);

    public static TResult ConvertToSync<TResult>(Func<Task<TResult>> input) => taskFactory.StartNew(input).Unwrap().GetAwaiter().GetResult();
}