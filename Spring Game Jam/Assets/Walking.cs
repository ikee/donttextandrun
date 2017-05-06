using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    // Static update
    private void FixedUpdate()
    {
        var newVelocity = new Vector3(0, 0, speed);


        if(Input.GetKey("left"))
        {
            newVelocity += Vector3.left * 3;
        }

        if (Input.GetKey("right"))
        {
            newVelocity += Vector3.right * 3;
        }

        rb.velocity = newVelocity;
    }

    // Update is called once per frame
    void Update () {
		
	} 
}
