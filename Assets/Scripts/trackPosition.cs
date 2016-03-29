using UnityEngine;
using System.Collections;

public class trackPosition : MonoBehaviour {

    public Transform followThis;
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = followThis.position;

        this.gameObject.SetActive(followThis.gameObject.activeInHierarchy);
	}
}
