using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingLight : MonoBehaviour
{
    public Light light;


    public void OnClick()
    {
        light.enabled = !light.enabled; //set enable and disable component
    }
}
