using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    private Weapon huntingBow = new Weapon("huntingBow", 100);
    private Weapon sword = new Weapon("sword", 50);

    Character hero = new Character("Jeff");
    Palladin knight;
    private Transform gameManagerTransform;
    private GameObject brickCube;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(hero.name);
        huntingBow.PrintWeaponStats();
        // sword wasn't happy until i put it here
        // Compiler Error CS0236 A field initializer cannot reference the nonstatic field, method, or property 'field'
        knight = new Palladin("Sir Arthur", huntingBow);

        // find the position of this GameManager object
        gameManagerTransform = this.GetComponent<Transform>();
        Debug.Log(gameManagerTransform.localPosition);

        //Find the Brick Cube\
        try
        {
            brickCube = GameObject.Find("BrickCube");
            Debug.Log(brickCube.transform.localPosition);
        }
        catch 
        { 
            Debug.Log("can't find brick");
        }
            
        
        
    }

   
}
