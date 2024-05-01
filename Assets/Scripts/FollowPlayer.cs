using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    //positions the camera so it's looking at the plane from the side
    private Vector3 offset = new Vector3 (30, 0, 10);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // puts the camera at the offset so that it is facing the plane's position
        transform.position = player.transform.position + offset;
    }
}
