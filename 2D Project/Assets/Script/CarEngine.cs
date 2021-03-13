using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CarEngine : MonoBehaviour
{
    public float lowSpeed;
    public float highSpeed;
    public float tLerpMax;
    public float tLerpRatio;
    public float backwardRatio;
    public float pitchRatio;
    public float pitchMin;
    public float pitchMax;
    [Space(5)]
    public Rigidbody2D wheelBack;
    public Rigidbody2D wheelFront;
    public AudioSource engineAudio;

    private float tLerp = 0;
    private bool isPushAnyKey = false;



    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            RayCast();
        }

        if (Input.GetMouseButtonUp(0))
        {
            isPushAnyKey = false;
        }

        if (!isPushAnyKey)
        {
            if (tLerp > 0)
                tLerp -= Time.deltaTime * tLerpRatio;
        }
    }

    private void Update()
    {
        EngineSound();
    }


    public void Forward()
    {
        Movement();
    }

    public void backward()
    {
        Movement(false);
    }

    private void Movement(bool isForward = true)
    {
        isPushAnyKey = true;
        float speed = Mathf.Lerp(lowSpeed, highSpeed, tLerp);
        if (tLerp < tLerpMax)
        {
            tLerp += Time.deltaTime * tLerpRatio;
        }

        if (isForward)
        {
            wheelBack.angularVelocity = -speed;
        }
        else
        {
            float angularVelocity = wheelBack.angularVelocity;
            if (angularVelocity < 0)
            {
                wheelBack.angularVelocity = 0;
                wheelFront.angularVelocity = 0;
            }

            if (Mathf.Round(wheelBack.velocity.x) <= 0)
            {
                wheelBack.angularVelocity = speed;
            }
        }
    }

    private void RayCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (hit)
        {
            switch (hit.transform.tag)
            {
                case "forwardKey":
                    Forward();
                    break;
                case "backwardKey":
                    backward();
                    break;
            }
        }
    }

    private void EngineSound()
    {
        float pitch = Mathf.Abs(tLerp) / pitchRatio;
        engineAudio.pitch = Mathf.Clamp(pitch, pitchMin, pitchMax);
    }
}
