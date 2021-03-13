using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.tag);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collision Stay");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision EXit");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger EXit");
    }

}
