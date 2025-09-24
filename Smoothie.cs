namespace smoothie_byggaren;

public class Smoothie
{
    
    //declaring the parameters for our objects
    public string Size {get; set;}
    public string SmoothieBase {get; set;}
    public string OptionalFruit {get; set;}
    
    
    
    //declaring a constructor
    public Smoothie(string smoothieBase, string optionalFruit, string size)
    {
        Size = size;
        SmoothieBase = smoothieBase;
        OptionalFruit = optionalFruit;
    }
    
    //returning to the objects
    public override string ToString(){
    return $"Fruit: {OptionalFruit} \nBase: {SmoothieBase} \nSize: {Size}";
    }
}