using AIOrchestrationEngine.Core.Interfaces;
using AIOrchestrationEngine.Core.Models;

namespace AIOrchestrationEngine.Steps
{
    public class TranslateStep : IStep
    {
        public string Name => "Translate";

        public StepResult Execute(WorkflowContext context)
        {
            var result = "Translated: " + context.Input;
            return StepResult.Ok(result);
        }
    }
}