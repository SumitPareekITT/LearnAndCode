using System;
using AIOrchestrationEngine.Core.Engine;
using AIOrchestrationEngine.Logging;
using AIOrchestrationEngine.Steps;
using AIOrchestrationEngine.Handlers;

namespace AIOrchestrationEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();

            var engine = new WorkflowEngine(logger);

            engine.AddStep(new GenerateStep(), retry: new RetryHandler(2));
            engine.AddStep(new SummarizeStep());
            engine.AddStep(
                new TranslateStep(),
                fallback: new FallbackHandler(new GenerateStep())
            );

            var result = engine.Execute("AI is amazing");

            Console.WriteLine("Final Output: " + result);
        }
    }
}