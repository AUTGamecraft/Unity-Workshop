using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public GameObject obj;
    public float moveSpeed;
    public float rotateSpeed;
    public Vector3 vector3;



    private void Update()
    {
        //  obj.transform.position = vector3; //set the position

        obj.transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime); //Translate
        obj.transform.Rotate(new Vector3(0, 0, 1) * rotateSpeed * Time.deltaTime); //Rotate
    }
}
