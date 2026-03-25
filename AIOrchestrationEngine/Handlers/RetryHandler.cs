using AIOrchestrationEngine.Core.Interfaces;
using AIOrchestrationEngine.Core.Models;

namespace AIOrchestrationEngine.Handlers
{
    public class RetryHandler
    {
        private readonly int _maxRetries;

        public RetryHandler(int maxRetries)
        {
            _maxRetries = maxRetries;
        }

        public StepResult ExecuteWithRetry(IStep step, WorkflowContext context)
        {
            int attempts = 0;

            while (attempts < _maxRetries)
            {
                var result = step.Execute(context);

                if (result.Success)
                    return result;

                attempts++;
            }

            return StepResult.Fail("Max retries exceeded");
        }
    }
}