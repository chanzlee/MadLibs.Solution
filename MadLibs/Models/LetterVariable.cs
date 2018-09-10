namespace MadLibs.Models
{
  public class LetterVariable
  {
    private string _person1;
    private string _person2;
    private string _animal;
    private string _exclamation;
    private string _verb;
    private string _noun;

    public void SetPerson1(string person1)
    {
      _person1 = person1;
    }
    public void SetPerson2(string person2)
    {
      _person2 = person2;
    }
    public void SetAnimal(string animal)
    {
      _animal = animal;
    }
    public void SetExclamation(string exclamation)
    {
      _exclamation = exclamation;
    }
    public void SetVerb(string verb)
    {
      _verb = verb;
    }
    public void SetNoun(string noun)
    {
      _noun = noun;
    }


    public string GetPerson1()
    {
      return _person1;
    }
    public string GetPerson2()
    {
      return _person2;
    }
    public string GetAnimal()
    {
      return _animal;
    }
    public string GetExclamation()
    {
      return _exclamation;
    }
    public string GetVerb()
    {
      return _verb;
    }
    public string GetNoun()
    {
      return _noun;
    }
  }
}
