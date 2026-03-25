using AIOrchestrationEngine.Core.Interfaces;
using AIOrchestrationEngine.Core.Models;

namespace AIOrchestrationEngine.Handlers
{
    public class FallbackHandler
    {
        private readonly IStep _fallbackStep;

        public FallbackHandler(IStep fallbackStep)
        {
            _fallbackStep = fallbackStep;
        }

        public StepResult Handle(WorkflowContext context)
        {
            return _fallbackStep.Execute(context);
        }
    }
}