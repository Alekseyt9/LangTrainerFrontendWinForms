

namespace LangTrainerFrontendWinForms.Helpers
{
    internal static class AsyncHelper
    {
        public static void DoAsync<T, D>(T obj, Func<D> getData, Action<T, D> act)
        {
            Task.Run(getData).ContinueWith(x => act(obj, x.Result));
        }

    }
}
