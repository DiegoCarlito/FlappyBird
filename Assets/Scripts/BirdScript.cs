using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) {
            myRigidbody.velocity = UnityEngine.Vector2.up * 10;
        }
    }
}
