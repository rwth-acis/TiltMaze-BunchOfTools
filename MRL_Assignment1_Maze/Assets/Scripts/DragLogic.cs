using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.UX;
public class DragLogic : MonoBehaviour {

    private HandDraggable handdrag;
    private BoundingBox box;

    // Use this for initialization
    void Awake()
    {
        box = GetComponent<BoundingBox>();
    }
    void Start () {
        handdrag = box.Target.GetComponent<HandDraggable>();
	}
	
	// Update is called once per frame
	void Update () {
        handdrag.IsDraggingEnabled = box.IsVisible;
	}
}
