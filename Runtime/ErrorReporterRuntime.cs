using System;

namespace Anatawa12.ErrorReporter
{
    public static class ErrorReporterRuntime
    {
        internal static event Action OnChangeAction;

        public static void TriggerChange()
        {
            OnChangeAction?.Invoke();
        }
    }
}
