using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    private CapsulePlayerController playerScript;
    private void Start()
    {
        playerScript = GameObject.Find("PlayerCapsule").GetComponent<CapsulePlayerController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerCapsule") {
            //Destroy(this.transform.parent.gameObject); //if HealthPickup was a child of 'ITEM' Gameobject
            //make sure contains
            if (playerScript.itemInventory.ContainsKey("Power Up")){
                playerScript.itemInventory["Power Up"] += 1;
                Debug.Log(playerScript.itemInventory["Power Up"]);
            }
            


            Destroy(this.transform.gameObject);

            Debug.Log("Item Collected!");
            }
        
    }
}
