using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorcard : MonoBehaviour
{
    public Animator doorAnim;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Grabbable"))
        {
            doorAnim.ResetTrigger("Close01");
            doorAnim.SetTrigger("Open01");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Grabbable"))
        {
            doorAnim.ResetTrigger("Open01");
            doorAnim.SetTrigger("Close01");
        }
    }
}