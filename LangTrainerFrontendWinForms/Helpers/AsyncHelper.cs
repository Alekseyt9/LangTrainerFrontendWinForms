

using LangTrainerFrontendWinForms.Services;

namespace LangTrainerFrontendWinForms.Helpers
{
    internal static class AsyncHelper
    {
        public static void DoAsync<T, D>(T obj, Func<D> getData, Action<T, D> act)
        {
            Task.Run(getData).ContinueWith(
                x =>
                {
                    if (x.IsFaulted)
                    {
                        if (x.Exception != null)
                        {
                            NotifyService.GetInstance().ShowMessage(x.Exception.Message);
                        }
                    }
                    else
                    {
                        if (x.IsCompleted)
                        {
                            act(obj, x.Result);
                        }
                    }
                });
        }

    }
}
