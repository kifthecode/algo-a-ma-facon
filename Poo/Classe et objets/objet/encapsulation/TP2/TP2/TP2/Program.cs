class Program
{
    static int Main()
    {
        Person john = new Person();
        john.SetName("Doe");
        john.SetFirstName("John");
        john.SetAge(35);


        Voiture audi = new Voiture(john);
        audi.SetBrand("Audi");
        audi.SetModel("TT");
        audi.SetRegistration("AV48CE");
        audi.SetOriginalInServiceDate(new DateTime(2012, 2, 21));
        audi.SetPower(211);
        audi.SetKLM(0);




        john.Print();
        audi.Print();
        return 0;
    }
}
