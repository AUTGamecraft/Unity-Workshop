using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCycle : MonoBehaviour
{
    /// <summary>
    ///Order of execution for event functions
    /// </summary>

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixed Update");
    }

    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        Debug.Log("On Disable");
    }

    private void OnDestroy()
    {
        Debug.Log("Destroy");
    }

}
