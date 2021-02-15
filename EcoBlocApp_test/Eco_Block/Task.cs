using System;
using System.Threading.Tasks;

public static class EcoBlocApp_test
{
  
    public static async void SafeFireAndForget(this Task task,
        bool returnToCallingContext,
        Action<Exception> onException = null)
    {
        try
        {
            await task.ConfigureAwait(returnToCallingContext);
        }

      
        catch (Exception ex) when (onException != null)
        {
            onException(ex);
        }
    }
}