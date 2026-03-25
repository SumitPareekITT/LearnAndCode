using AIOrchestrationEngine.Core.Models;

namespace AIOrchestrationEngine.Core.Interfaces
{
    public interface IStep
    {
        string Name { get; }
        StepResult Execute(WorkflowContext context);
    }
}