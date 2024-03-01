public class Animais
{
    public string Species { get; set; }
    public string ID { get; set; }
    public string Age { get; set; }
    public string PhysicalDescription { get; set; }
    public string PersonalityDescription { get; set; }
    public string Nickname { get; set; }
    public decimal SuggestedDonation { get; set; }

    public Animais(string species, string id, string age, string physicalDescription, string personalityDescription, string nickname, decimal suggestedDonation)
    {
        Species = species;
        ID = id;
        Age = age;
        PhysicalDescription = physicalDescription;
        PersonalityDescription = personalityDescription;
        Nickname = nickname;
        SuggestedDonation = suggestedDonation;
    }
}