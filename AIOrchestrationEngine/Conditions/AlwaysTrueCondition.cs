using AIOrchestrationEngine.Core.Interfaces;
using AIOrchestrationEngine.Core.Models;

namespace AIOrchestrationEngine.Conditions
{
    public class AlwaysTrueCondition : ICondition
    {
        public bool Evaluate(WorkflowContext context)
        {
            return true;
        }
    }
}