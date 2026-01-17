using System;

class SaveUserRefactor
{
    static void Main()
    {
        var user = new User { Id = 1, Name = "Sumit", Email = "sumit@email.com" };
        SaveUser(user);
    }

    static void SaveUser(User user)
    {
        if (!ValidateUser(user))
        {
            Console.WriteLine("Invalid user data");
            return;
        }

        SaveToDatabase(user);
        BackupUser(user);
    }

    static bool ValidateUser(User user)
    {
        return !(string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Email));
    }

    static void SaveToDatabase(User user)
    {
        Console.WriteLine("User inserted into database");
    }

    static void BackupUser(User user)
    {
        string filePath = $"/backup/users/{user.Id}.txt";
        Console.WriteLine($"User backup saved at {filePath}");
    }
}

class User
{
    public int Id;
    public string Name;
    public string Email;
}
