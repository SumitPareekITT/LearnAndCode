using System;
using ATMRefactoring.Exceptions;
using ATMRefactoring.Models;

namespace ATMRefactoring.Services
{
    public class ATMService
    {
        public void Withdraw(string accountId, double amount)
        {
            var handle = GetHandle();

            var record = GetDeviceRecord(handle);

            ValidateDevice(record);
            ValidateConnection(record);
            ValidateBalance(accountId, amount);

            DispenseCash(handle, amount);
        }

        private void ValidateDevice(DeviceRecord record)
        {
            if (record.IsLocked)
                throw new DeviceLockedException("ATM device is locked");
        }

        private void ValidateConnection(DeviceRecord record)
        {
            if (!record.IsConnected)
                throw new NetworkConnectionException("No network connection");
        }

        private void ValidateBalance(string accountId, double amount)
        {
            double balance = GetBalance(accountId);

            if (balance < amount)
                throw new InsufficientFundsException("Insufficient funds");
        }


        private DeviceHandle GetHandle()
        {
            return new DeviceHandle(true);
        }

        private DeviceRecord GetDeviceRecord(DeviceHandle handle)
        {
            return new DeviceRecord
            {
                IsLocked = false,
                IsConnected = true
            };
        }

        private double GetBalance(string accountId)
        {
            return 1000;
        }

        private void DispenseCash(DeviceHandle handle, double amount)
        {
            Console.WriteLine($"Dispensed {amount}");
        }
    }
}