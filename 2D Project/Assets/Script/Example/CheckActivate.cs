using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckActivate : MonoBehaviour
{
    public GameObject obj;



   
    void Update()
    {
        Debug.Log("activeSelf: " + obj.activeSelf); //The local active state of this GameObject. (Read Only)
        Debug.Log("activeInHierarchy: " + obj.activeInHierarchy); //Defines whether the GameObject is active in the Scene.
    }

    public void OnClick()
    {
        obj.SetActive(true); // activate refrence gameObject
        gameObject.SetActive(true); // activate current gameObject
    }
}
