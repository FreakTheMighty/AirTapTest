using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour, IInputClickHandler
{
    public Material defaultMaterial;
    public Material clickMaterial;
    public bool clicked = false;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("ClickHandler.OnInputDown");
        if (clicked)
        {
            GetComponent<Renderer>().material = defaultMaterial;
        } else
        {
            GetComponent<Renderer>().material = clickMaterial;
        }
        clicked = clicked == false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
