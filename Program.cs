using lab4_1;

using(HelloappContext db = new HelloappContext())
{
    List<User> users = db.Users.ToList();
    Console.WriteLine("users:");
    foreach (User user in users)
    {
        Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
    }
}
