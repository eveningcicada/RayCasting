using UnityEngine;
using System.Collections;

public class raycastMouseLook : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(-mouseY, mouseX, 0f);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,
                                                 transform.localEulerAngles.y,
                                                 0f);

        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Cursor.visible = true;
        }

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit rayHitInfo = new RaycastHit();
        if ( Physics.Raycast( ray, out rayHitInfo, 1000f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                rayHitInfo.transform.localScale *= 0.9f;
            }
        }

    }
}
