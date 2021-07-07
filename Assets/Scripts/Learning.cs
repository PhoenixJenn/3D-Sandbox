using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{

    /// <summary>
    ///  TODO : 
    ///  Abstract Class
    ///  Struct
    ///  Inheritance
    ///  Polymorphism
    ///  TypeConversions p 61: explicit vs implicit\
    ///  async functions
    ///  list ; dictionary; array methods
    /// </summary>

    private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;


    public string CharacterClass = "Ranger";

    Weapon huntingBow = new Weapon("Hunting Bow", 105);
    //
    Character hero = new Character();

    private void Start()
    {

        camTransform = this.GetComponent<Transform>();
        directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
        // You can chain method calls 
        //lightTransform = GameObject.Find("Directional Light").GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);
        hero.name = "Sir Tomas the brave";
        hero.exp = 150;
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        int characterHealth = 100;
        Debug.Log(CharacterClass + " -HP:" + characterHealth);

    }

    void CreateCharacter() {

        string characterName = "Aragorn";
        Debug.Log("Character:" + characterName + " ;" + CharacterClass);
    }
 
}
