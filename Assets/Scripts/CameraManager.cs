using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // camera will follow this object
    public Transform Target;
    //camera transform
    public Transform camTransform;
    // offset between camera and target
    public Vector3 Offset;
    // change this value to get desired smoothness
    public float SmoothTime = 0.3f;
 
    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;
 
    private void Start()
    {
        Offset = camTransform.position - Target.position;
    }
 
    private void LateUpdate()
    {
        // update position
        Vector3 targetPosition = Target.position + Offset;
       // camTransform.position = Vector3.Lerp(transform.position, new Vector3(0f,targetPosition.y,targetPosition.z), SmoothTime*Time.deltaTime);
        camTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, SmoothTime);
       // camTransform.position = Vector3.Lerp (camTransform.position, targetPosition, SmoothTime);

 
        // update rotation
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // public Transform target;
    //
    // public float smoothSpeed = 0.125f;
    // public Vector3 offset;
    //
    // void LateUpdate()
    // {
    //     if (target == null)
    //         return;
    //     Vector3 desiredPosition = target.position + offset;
    //     Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    //     transform.position = smoothedPosition;
    // }
}
