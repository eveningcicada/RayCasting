using UnityEngine;
using System.Collections;

public class hideSeekDemo : MonoBehaviour {

    public Transform cylinder;
	// Update is called once per frame
	void Update ()
    {
        Ray losRay = new Ray(transform.position, cylinder.position - transform.position);

        RaycastHit losHitInfo = new RaycastHit();

        float distance = (cylinder.position - transform.position).magnitude;

        if (Physics.Raycast(losRay, out losHitInfo, distance))
        {
            if (losHitInfo.collider.tag == "GrowthCapsule")
            {
                transform.localScale *= 1.01f;
            }
            else
            {

            }
        }
	}
}
