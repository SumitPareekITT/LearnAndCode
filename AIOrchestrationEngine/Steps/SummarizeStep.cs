using AIOrchestrationEngine.Core.Interfaces;
using AIOrchestrationEngine.Core.Models;

namespace AIOrchestrationEngine.Steps
{
    public class SummarizeStep : IStep
    {
        public string Name => "Summarize";

        public StepResult Execute(WorkflowContext context)
        {
            var result = "Summary of: " + context.Input;
            return StepResult.Ok(result);
        }
    }
}