// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to university management!");

List<Person> uniMember = new List<Person>();

universityMembers.Add(new Student("Ali shabani", 22, 99123, "Computer Science‌"));



 public void DisolayMembers() {
    foreach (var person in universityMembers)
    {
        Console.WriteLine(person.GetDetails());
        Console.WriteLine();
    }
}
