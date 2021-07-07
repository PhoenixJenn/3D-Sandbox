using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palladin : Character
{
    public Weapon weapon;
    /// <summary>
    /// Calls the parent constructor and passes in the string 'name'
    /// </summary>
    /// <param name="name"></param>
    public Palladin(string name, Weapon weapon) : base(name) {
        this.weapon = weapon;
    }

}
