using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTransform : MonoBehaviour
{
    public Transform otherPlane;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CloneCharacter"))
        {
            otherPlane.position += new Vector3(0,0,45);
        }
    }
}
