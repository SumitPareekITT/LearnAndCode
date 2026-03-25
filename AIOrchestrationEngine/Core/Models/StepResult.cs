namespace AIOrchestrationEngine.Core.Models
{
    public class StepResult
    {
        public bool Success { get; set; }
        public string Output { get; set; }
        public string Error { get; set; }

        public static StepResult Ok(string output)
        {
            return new StepResult
            {
                Success = true,
                Output = output
            };
        }

        public static StepResult Fail(string error)
        {
            return new StepResult
            {
                Success = false,
                Error = error
            };
        }
    }
}