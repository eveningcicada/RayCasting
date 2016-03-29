using UnityEngine;
using System.Collections;

public class raycastDemo : MonoBehaviour {

    public Transform sphere;
    public Transform paintSphere;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Step1 construct your ray

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //ScreenPointToRay is a special function that will take a pixel
        //coordinate on screen, and generate a ray based on it

        //Step2 initialize your raycast hi variable

        RaycastHit rayHitInfo = new RaycastHit();
        //RaycastHit will tell you what you hit, and where, etc.

        //Step2B Debug ray
        Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.cyan);

        //Step3 actually fire the Raycast
        if(Physics.Raycast(ray, out rayHitInfo, 1000f))
        {
            Debug.DrawRay(ray.origin, ray.direction * rayHitInfo.distance, Color.red);

            //All code in here will assume we hit something
            sphere.position = rayHitInfo.point;

            if(Input.GetMouseButton(0))
            {
                Instantiate(paintSphere, rayHitInfo.point, Quaternion.identity);
            }
        }
	}
}
