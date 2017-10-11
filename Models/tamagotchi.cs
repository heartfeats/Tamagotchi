using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Tama
  {
    private string _name;
    private int _food;
    private int _attention;
    private int _rest;
    private static List<Tama> _instances = new List<Tama> {};

    //this is the constructor
    public Tama (string name)
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
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
  }
}
