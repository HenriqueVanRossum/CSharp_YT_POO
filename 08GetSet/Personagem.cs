using System;
using System.Security.Cryptography.X509Certificates;
namespace _08GetSet
{

  class Personagem
  {
    private string name= "";
    private int power;
    private int life = 3000;

    private int defense;

    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    
    public int Power
    {
      get { return power; }
      set { power = value; }
    }
    
    public int Defense
    {
      get { return defense; }
      set { defense = value; }
    }

    public int Life 
    {
      get { return life; }
      set { life = value; }
    }
  }
}

  
    


