using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject grabbedObject;

    public Transform grabPos;


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Input.GetKeyDown(KeyCode.E) && Physics.Raycast(transform.position, transform.forward, out hit, 5) && hit.transform.GetComponent<Rigidbody>() && hit.transform.tag == "Grabbable")
        {
            Debug.Log("grab");
            grabbedObject = hit.transform.gameObject;
        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            grabbedObject = null;
        }
        if(grabbedObject != null)
        {
            grabbedObject.GetComponent<Rigidbody>().velocity = 10 * (grabPos.position - grabbedObject.transform.position);
        }

    }
}
