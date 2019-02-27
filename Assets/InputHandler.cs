using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour, IInputHandler
{
    public Material defaultMaterial;
    public Material clickMaterial;

    public void OnInputDown(InputEventData eventData)
    {
        Debug.Log("InputHandler.OnInputDown");
        GetComponent<Renderer>().material = clickMaterial;
    }

    public void OnInputUp(InputEventData eventData)
    {
        Debug.Log("InputHandler.OnInputUp");
        GetComponent<Renderer>().material = defaultMaterial;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
