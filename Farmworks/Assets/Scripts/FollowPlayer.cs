using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; 

    private void LateUpdate()
    {
        if (player != null)
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

    
}
