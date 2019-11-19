using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script which observes if the player has won the game
/// </summary>
public class WinningCondition : MonoBehaviour
{
    [Tooltip("The prefab for the confetti particle system")]
    public GameObject confettiPrefab;

    /// <summary>
    /// Instantiates the confetti particle system in the scene so that it can be accessed
    /// </summary>
    private void Start()
    {
        GameObject instance = Instantiate(confettiPrefab);
        transform.parent.GetComponent<GameController>().confettiCanon = instance;
    }

    /// <summary>
    /// Called by Unity if an object enters a trigger volume
    /// Shoots confetti if the marble enters the trigger volume around the flag
    /// </summary>
    /// <param name="other">The collider which entered the trigger volume</param>
    private void OnTriggerEnter(Collider other)
    {
        // if the marble entered the volume, shoot confetti above the flag
        if (other.tag == "Marble")
        {
            ConfettiManager.Instance.ShootConfetti(transform.position + 0.05f * transform.up);
        }
    }
}
