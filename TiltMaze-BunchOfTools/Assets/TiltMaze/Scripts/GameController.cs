using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Tooltip("The marble ball")]
    public Transform marble;
    [Tooltip("The doors in the maze")]
    public DoorController[] doors;
    [Tooltip("The confetti canon instance")]
    [HideInInspector]
    public GameObject confettiCanon;

    private Vector3 marbleStartPosition;

    /// <summary>
    /// Saves the current position of the marble as the starting position
    /// </summary>
    private void Awake()
    {
        marbleStartPosition = marble.position;
    }

    /// <summary>
    /// Resets every game element to its starting state so that a fresh game can be started again
    /// </summary>
    public void ResetGame()
    {
        transform.rotation = Quaternion.identity;
        marble.position = marbleStartPosition;
        foreach (DoorController door in doors)
        {
            door.DoorOpen = false;
        }
        confettiCanon.SetActive(false);
    }
}
