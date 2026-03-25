using AIOrchestrationEngine.Core.Models;

namespace AIOrchestrationEngine.Core.Interfaces
{
    public interface ICondition
    {
        bool Evaluate(WorkflowContext context);
    }
}