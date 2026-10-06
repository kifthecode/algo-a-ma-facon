class Program
{
    static int Main()
    {
        Person john = new Person();
        john.Name = "Doe";
        john.FirstName = "John";
        john.Age = 35;


        Voiture audi = new Voiture();
        audi.Brand = "Audi";
        audi.Model = "TT";
        audi.Registration = "AV48CE";
        audi.OriginalInServiceDate = new DateTime(2012, 2, 21);
        audi.Power = 211;
        audi.KLM = 0;
        audi.Owner = john;

        john.Print();
        audi.Print();
        return 0;
    }
}







