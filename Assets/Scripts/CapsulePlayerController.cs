using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulePlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float forwardInput;
    private float speed = 4.0f;
    private float turnSpeed = 30.0f;
    private Rigidbody rb;

    private int playerLives =2; 

    public Dictionary<string, int> itemInventory = new Dictionary<string, int>() {
        { "Power Up", 0},
        { "Lives", 0}
    };


    // Update is called once per frame
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        CollectItem("Lives", playerLives); // different levels can init different lives
        ShowItems();
              
    }

    private void ShowItems() {
        foreach(KeyValuePair<string, int> kvp in itemInventory) { 
            Debug.Log("ItemInventory:" + kvp.Key + " : " + kvp.Value);
        }
        
        //for loop use itemInventory.Count
    }

    public void CollectItem(string item, int itemValue) {

        if (itemInventory.ContainsKey(item))
        {
            itemInventory[item] += 1;
            Debug.Log(itemInventory[item]);
        }
    }
    // need to use FixedUpdate for physics
    private void FixedUpdate()
    {
        MovePlayerFixedUpdate();
    }

    private void MovePlayerFixedUpdate()
    {
        forwardInput = Input.GetAxis("Vertical") * speed;
        horizontalInput = Input.GetAxis("Horizontal");

        Vector3 rotation = Vector3.up * horizontalInput * turnSpeed;
        Quaternion angleRot = Quaternion.Euler(rotation  * Time.fixedDeltaTime);

        rb.MovePosition(this.transform.position + this.transform.forward * forwardInput * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation  * angleRot );
       
    }
}



