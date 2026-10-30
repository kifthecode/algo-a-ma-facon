namespace Bases;

// le garagistre recoit ses skills sa competence en pourcentage
public class Garagiste : Person
{
  public int Skills { get; set; }

  public Garagiste(string name, string firstName, int age, int skills) : base(name, firstName, age)
  {
    Skills = skills;
  }
}