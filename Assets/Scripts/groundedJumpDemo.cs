using UnityEngine;
using System.Collections;

public class groundedJumpDemo : MonoBehaviour {

    bool jumpPressed = false;
    bool grounded = false;

	void Update()
    {
        Ray groundRay = new Ray(transform.position, Vector3.down);

        //RaycastHit - think footstep sounds, or friction values, or lava damage

        if (Physics.Raycast(groundRay, 1.05f))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
        }
        else
        {
            jumpPressed = false;
        }
    }
	
	// Update is called once per physics frame
	void FixedUpdate ()
    {
        //JampMan JumpMan
        if (jumpPressed && grounded)
        {
            GetComponent<Rigidbody>().velocity += (Vector3.up * 10f);
        }
	}
}
