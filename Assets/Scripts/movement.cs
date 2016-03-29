using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    /*
    // Movement.cs script:
    FIXED UPDATE:
set rigidbody velocity equal to[current forward direction] * 10f + Physics.gravity
declare a var of type Ray, called "moveRay" that starts from[current position] and goes[current forward direction]
// a spherecast is like a thick raycast... google it!
if Physics.Spherecast with moveRay of radius 1 for distance 3 is TRUE... (if there is an obstacle in front of us...)
     then randomly turn 90 degrees left or right(around Y axis)
     */

    Ray moveRay;

    // Update is called once per frame
    void FixedUpdate ()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * 10f + Physics.gravity;

        moveRay = new Ray(transform.position, transform.forward);

        //Debug.DrawRay(transform.position, transform.forward, Color.cyan);

        if (Physics.SphereCast(moveRay, 0.5f, 1.25f))
        {

            int randturn = Random.Range(0, 2);

            if (randturn == 0)
            {
                transform.localEulerAngles += transform.up * 90;
            }
            else
            {
                transform.localEulerAngles -= transform.up * 90;
            }
        }

	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawRay(transform.position, transform.forward * 1.25f);
        Gizmos.DrawSphere(transform.position + transform.forward * 1.25f, 0.5f);
    }
}
