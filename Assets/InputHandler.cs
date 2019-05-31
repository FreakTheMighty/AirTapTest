using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour, IInputHandler
{
    public TextMesh textMesh;
    public bool clicked = false;
    public Material clickMaterial;
    public Material defaultMaterial;

    public void OnInputDown(InputEventData eventData)
    {
        GetComponent<Renderer>().material = clickMaterial;
        if (clicked)
        {
            WorldAnchorManager.Instance.AttachAnchor(gameObject, "AnchorName");
        }
        else
        {
            WorldAnchorManager.Instance.RemoveAnchor("AnchorName");
        }
        clicked = clicked == false;
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
        string[] ids = WorldAnchorManager.Instance.AnchorStore.GetAllIds();
        textMesh.text = "Anchor IDs: " + String.Join(",", ids);
    }
}
