using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour,IInputClickHandler {

    private DoorController door;

    private void Awake()
    {
        door = GetComponent<DoorController>();
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (door == null)
        {
            Debug.LogError("No DoorController found on the object");
            return;
        }
        door.DoorOpen = !door.DoorOpen;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
