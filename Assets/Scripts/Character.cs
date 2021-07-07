using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string name;
    public int exp;

   
    public Character() {
        name = "not assigned";
    }

    public Character(string newName)
    {
        name = newName;
    }
 

}
public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;

    }
    public void PrintStatsInfo() {
        Debug.Log("Character:" + name + "; Damage:" + damage);
        
    }
    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon:{0} - {1} DMB", name, damage);

    }
}
