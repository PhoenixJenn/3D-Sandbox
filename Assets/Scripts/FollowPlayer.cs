using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(4,2,0);
    
    // LateUpdate is good for camera movement because it is called once/frame after Update has finished
    void LateUpdate()
    {
        // this makes it pan right left only
        //float horizontalInput = Input.GetAxis("Horizontal");
       // transform.Rotate(Vector3.up, horizontalInput * 45.0f * Time.deltaTime);

        //  get player's X and Z position; follow player; Lookat Player

        
        //always behind the player
        transform.position = player.transform.position + offset;
        //pivots to look at player
        //
        transform.LookAt(player.transform);
    }
}
