using System.Collections.Generic;

namespace TamagotchiGame.Models
{
  public class Tamagotchi
  {
    private string _name;
    private int _food;
    private int _attention;
    private int _rest;
    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

    //this is the constructor
    public Tamagotchi (string name)
    {
      _name = name;
      _food = 50;
      _attention = 50;
      _rest = 50;
    }

    public string GetName()
    {
      return _name;
    }

    public void Feed()
    {
      _food += 15;
      _attention -= 5;
      _rest -= 5;
    }

    public int GetFood()
    {
      return _food;
    }

    public void Play()
    {
      _food -= 5;
      _attention += 15;
      _rest -= 5;
    }

    public int GetAttention()
    {
      return _attention;
    }

    public void Sleep()
    {
      _food -= 5;
      _attention -= 5;
      _rest += 15;
    }

    public int GetRest()
    {
      return _rest;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
  }
}
