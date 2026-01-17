using System.Threading.Tasks;
using System.Collections.Generic;

public interface IPaymentGateway
{
    Task<PaymentResult> ProcessPayment(string customerId, decimal amount, string paymentMethod);
    Task RefundPayment(string transactionId);
}

public interface IInventoryService
{
    Task<bool> CheckAvailability(List<string> items);
    Task ReserveItems(List<string> items);
    Task CommitReservation(List<string> items);
    Task ReleaseReservation(List<string> items);
    Task RestoreInventory(List<string> items);
}

public interface INotificationService
{
    Task SendOrderConfirmation(Order order);
}
