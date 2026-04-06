using System;
using ATMRefactoring.Exceptions;
using ATMRefactoring.Services;

namespace ATMRefactoring.Controllers
{
    public class ATMDeviceController
    {
        private readonly ATMService _service = new ATMService();

        public void Withdraw(string accountId, double amount)
        {
            try
            {
                _service.Withdraw(accountId, amount);
                Console.WriteLine("Transaction successful");
            }
            catch (DeviceLockedException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (NetworkConnectionException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}