using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // sets the speed of the propeller spin
    private float propellerspeed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // makes the propeller on the plane spin
        transform.Rotate(Vector3.forward, propellerspeed * Time.deltaTime);
    }
}
