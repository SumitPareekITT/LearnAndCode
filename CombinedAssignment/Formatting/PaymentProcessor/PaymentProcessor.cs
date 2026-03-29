using System;
using System.Collections.Generic;

namespace Payment.Processing
{
    public class PaymentProcessor
    {
        private static readonly decimal MIN_AMOUNT = 0.01m;
        private const int MAX_RETRIES = 2;
        private const string PAYMENT_SUCCESS = "Payment successful";
        private const string PAYMENT_FAILED = "Payment failed";

        private readonly ILogger logger;
        private readonly INotificationService notifier;
        private readonly Dictionary<string, PaymentRecord> history;

        public PaymentProcessor(ILogger logger, INotificationService notifier)
        {
            this.logger = logger;
            this.notifier = notifier;
            this.history = new Dictionary<string, PaymentRecord>();
        }

        public PaymentResult Process(PaymentRequest request)
        {
            Validate(request);

            int attempt = 0;

            while (attempt < MAX_RETRIES)
            {
                try
                {
                    Execute(request);
                    Record(request);
                    NotifySuccess(request);

                    return new PaymentResult(true, PAYMENT_SUCCESS, GenerateId());
                }
                catch (PaymentException)
                {
                    attempt++;
                    logger.Log($"Retry attempt: {attempt}");
                }
            }

            return new PaymentResult(false, PAYMENT_FAILED, null);
        }

        private void Validate(PaymentRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.CustomerId))
                throw new ArgumentException("Customer ID required");

            if (request.Amount < MIN_AMOUNT)
                throw new ArgumentException("Invalid amount");
        }

        private void Execute(PaymentRequest request)
        {
            logger.Log($"Executing payment of {request.Amount}");

            if (request.Amount > 5000m)
                throw new PaymentException("Limit exceeded");
        }

        private void Record(PaymentRequest request)
        {
            history[GenerateId()] = new PaymentRecord(
                request.CustomerId,
                request.Amount,
                DateTime.Now
            );
        }

        private void NotifySuccess(PaymentRequest request)
        {
            notifier.Send(request.CustomerId, $"Payment of {request.Amount} processed");
        }

        private string GenerateId()
        {
            return $"TXN-{DateTimeOffset.Now.ToUnixTimeMilliseconds()}";
        }
    }
}
