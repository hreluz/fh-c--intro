partial class Program
{
    static void Visibility()
    {
        Jedi jedi = new Jedi();
        jedi.PowerLevel = 5000;
        jedi.LightSaberColor = "blue";
        jedi.UseForce();

        WriteLine(jedi.PublicField);
        WriteLine(jedi.PowerLevel);
        jedi.RevealSecrets();

        Sith sith = new Sith();
        sith.LightSaberColor = "red";
        // sith.ShowProtected();
        sith.UseForce();
    }
}

interface IForceUser
{
    int PowerLevel { get; set; }
    string LightSaberColor { get; set; }

    void UseForce();
}

class Jedi:IForceUser
{
    public string PublicField = "I am a Jedi";
    private string PrivateFields = "My personal thoughts";
    protected string ProtectedField = "This is a protected field";

    public int PowerLevel { get; set; }
    public string? LightSaberColor { get; set; }

    public void UseForce()
    {
        WriteLine($"I am a jedi with a light sabercolor {LightSaberColor}, and my level power is {PowerLevel}");
    }

    protected void Train()
    {
        WriteLine("I am training to become the best jedi ever");
    }

    public void RevealSecrets()
    {
        WriteLine(ProtectedField);
        WriteLine(PrivateFields);
    }
}


class Sith : Jedi, IForceUser
{
    public new void UseForce()
    {
        WriteLine($"I am a sith with a light sabercolor {LightSaberColor}, and my level power is {PowerLevel}");
    }
    public void ShowProtected()
    {
        WriteLine(ProtectedField);
        Train();
    }
    
}