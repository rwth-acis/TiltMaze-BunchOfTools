using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the doors
/// </summary>
public class DoorController : MonoBehaviour
{
    private bool doorOpen = false;
    private Vector3 closedPosition;

    /// <summary>
    /// Saves the starting position as the closed position
    /// </summary>
    private void Start()
    {
        closedPosition = transform.localPosition;
    }

    /// <summary>
    /// States whether the door is open or not
    /// Changing this value will automatically move the door into the corresponding state
    /// </summary>
    public bool DoorOpen
    {
        get
        {
            return doorOpen;
        }
        set
        {
            StopAllCoroutines();
            if (value)
            {
                OpenDoor();
            }
            else
            {
                CloseDoor();
            }
            doorOpen = value;
        }
    }

    /// <summary>
    /// Opens the door if it was closed
    /// </summary>
    private void OpenDoor()
    {
        if (!doorOpen)
        {
            StartCoroutine(Move(closedPosition + new Vector3(0, transform.localScale.y, 0), 1f));
        }
    }

    /// <summary>
    /// Closes the door if it was open
    /// </summary>
    private void CloseDoor()
    {
        if (doorOpen)
        {
            StartCoroutine(Move(closedPosition, 1f));
        }
    }

    /// <summary>
    /// Co-routine which moves an object from its current position to the targetPosition in the given duration
    /// </summary>
    /// <param name="targetPosition">The position where the object should be at the end of the movement</param>
    /// <param name="time">The time that the movement should take</param>
    /// <returns></returns>
    private IEnumerator Move(Vector3 targetPosition, float time)
    {
        Vector3 startPosition = transform.localPosition;
        float elapsedTime = 0f;
        while(elapsedTime < time)
        {
            transform.localPosition = Vector3.Lerp(startPosition, targetPosition, elapsedTime / time);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = targetPosition;
    }
}
