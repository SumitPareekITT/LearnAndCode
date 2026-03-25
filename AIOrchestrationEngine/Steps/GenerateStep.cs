using AIOrchestrationEngine.Core.Interfaces;
using AIOrchestrationEngine.Core.Models;

namespace AIOrchestrationEngine.Steps
{
    public class GenerateStep : IStep
    {
        public string Name => "Generate";

        public StepResult Execute(WorkflowContext context)
        {
            var result = "Generated: " + context.Input;
            return StepResult.Ok(result);
        }
    }
}