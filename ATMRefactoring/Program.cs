using System;   // ✅ REQUIRED

using ATMRefactoring.Controllers;

class Program
{
    static void Main()
    {
        var controller = new ATMDeviceController();
        controller.Withdraw("ACC123", 500);
    }
}