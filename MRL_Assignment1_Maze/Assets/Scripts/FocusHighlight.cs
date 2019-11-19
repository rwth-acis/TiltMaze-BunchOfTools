using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class FocusHighlight : MonoBehaviour, IFocusable {

    Renderer rend;


    public Color defaultColor = Color.green;
    public Color highlightColor = Color.red;

    private void Awake()
    {
        rend = gameObject.GetComponent<Renderer>();

    }

    public void OnFocusEnter()
    {
        rend.material.color = highlightColor;
    }

    public void OnFocusExit()
    {
        rend.material.color = defaultColor;
    }

    // Use this for initialization
    void Start () {
        rend.material.color = defaultColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
