using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    private Vector3 targetPos;

    public float toFoward;
    public float smoothing;
    public Vector3 offset = new Vector3();

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector3(target.transform.position.x,target.transform.position.y,target.transform.position.z);
      
        if (target.transform.localScale.x ==  1) // RIGHT
        {
            targetPos = new Vector3(targetPos.x+toFoward,targetPos.y,transform.position.z) + offset;
        }
        if (target.transform.localScale.x ==  -1) // LEFT
        {
            targetPos = new Vector3(targetPos.x+toFoward,targetPos.y,transform.position.z)+offset;
        }

        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing * Time.deltaTime) ;
    }
}
