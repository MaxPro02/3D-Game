using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField]
    Vector3 v3Force;

    // Start is called before the first frame update
    [SerializeField]
    KeyCode keyPostitive;

    [SerializeField]
    KeyCode keyNegative;

    void FixedUpdate() 
    {
        if (Input.GetKey(keyPostitive))
        GetComponent<Rigidbody>().velocity += v3Force;

        if (Input.GetKey(keyNegative))
        GetComponent<Rigidbody>().velocity -= v3Force;
        
    }
        

    

}
