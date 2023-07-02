using FitnessClub.Domain;
using FitnessClub.Factoriesa;

class Program
{

    static void Main()
    {

        Console.WriteLine(">>> Welcome to FitnessCLub CRM <<<\n");
        Console.WriteLine("> Enter the memberhsip type u would like to create: ");
        Console.WriteLine(" > G - Gym ");
        Console.WriteLine(" > P - Gym  + Pool");
        Console.WriteLine(" > T  - Personal Training ");

        string membershipType = Console.ReadLine();

        MembershipFactory factory = GetFactory(membershipType);

        IMembership membership = factory.GetMembership();

        Console.WriteLine("\n> Membership you have chosen : \n");


        Console.WriteLine(
            $"\tName:\t\t{membership.Name}\n" +
            $"\tDescription:\t{membership.Description}\n" +
            $"\tPrice:\t\t{membership.GetPrice()}");



        Console.ReadLine();
    }

    


    private static MembershipFactory GetFactory(string membershipType) =>

        membershipType.ToLower() switch
        {

            "g" => new GymMembershipFactory(100, "Basic Membership"),
            "p" => new GymPlusPoolMembershipFactory(250, "Good Price Membership"),
            "t" => new PersonalTraingingMembershipFactory(400, "Best Price Membership"),
            _ => null


        };
}
