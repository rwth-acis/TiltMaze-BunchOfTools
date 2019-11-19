using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class MazeMover : MonoBehaviour, IManipulationHandler
{
    private Vector3 startPosition = new Vector3();
    public float lerpSpeed = 10f;

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        InputManager.Instance.OverrideFocusedObject = null;
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        InputManager.Instance.OverrideFocusedObject = null;
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        InputManager.Instance.OverrideFocusedObject = gameObject;
    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        Vector3 targetPosition = startPosition + eventData.CumulativeDelta;
        Vector3 upAxis = targetPosition - transform.parent.position;
        transform.parent.up = Vector3.Lerp(transform.parent.up, upAxis, lerpSpeed * Time.deltaTime);
    }


    // Use this for initialization
    void Start () {
        startPosition = gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
