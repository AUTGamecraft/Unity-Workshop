using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector2 offset;
    public float yClampMin;
    public float yClampMax;
    public float smoothTime;


    private void FixedUpdate()
    {
        if (target)
            Follower();
    }

    private void Follower()
    {
        float yPos = Mathf.Clamp(target.transform.position.y + offset.y, yClampMin, yClampMax);
        float Vref = 0.0f;
        float camX = Mathf.SmoothDamp(transform.position.x, target.transform.position.x + offset.x, ref Vref, smoothTime * Time.deltaTime);
        float camY = Mathf.SmoothDamp(transform.position.y, yPos, ref Vref, smoothTime * Time.deltaTime); //TODO : check this
        Vector3 targetPos = new Vector3(camX, yPos, transform.position.z);
        transform.position = targetPos;
    }
}
