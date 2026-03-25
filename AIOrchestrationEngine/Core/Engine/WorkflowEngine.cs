using System;
using System.Collections.Generic;
using AIOrchestrationEngine.Core.Interfaces;
using AIOrchestrationEngine.Core.Models;
using AIOrchestrationEngine.Conditions;
using AIOrchestrationEngine.Handlers;

namespace AIOrchestrationEngine.Core.Engine
{
    public class WorkflowEngine
    {
        private readonly List<(IStep step, ICondition condition, RetryHandler retry, FallbackHandler fallback)> _steps;
        private readonly ILogger _logger;

        public WorkflowEngine(ILogger logger)
        {
            _steps = new List<(IStep, ICondition, RetryHandler, FallbackHandler)>();
            _logger = logger;
        }

        public void AddStep(
            IStep step,
            ICondition condition = null,
            RetryHandler retry = null,
            FallbackHandler fallback = null)
        {
            _steps.Add((
                step,
                condition ?? new AlwaysTrueCondition(),
                retry,
                fallback
            ));
        }

        public string Execute(string input)
        {
            var context = new WorkflowContext { Input = input };

            foreach (var (step, condition, retry, fallback) in _steps)
            {
                if (!condition.Evaluate(context))
                    continue;

                _logger.Log($"Executing step: {step.Name}");

                StepResult result = retry != null
                    ? retry.ExecuteWithRetry(step, context)
                    : step.Execute(context);

                if (!result.Success)
                {
                    _logger.Log($"Step failed: {step.Name}");

                    if (fallback != null)
                    {
                        result = fallback.Handle(context);
                    }
                    else
                    {
                        throw new Exception(result.Error);
                    }
                }

                context.Input = result.Output;
            }

            return context.Input;
        }
    }
}