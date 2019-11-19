using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manager that can be accessed by other scripts to request confetti
/// </summary>
public class ConfettiManager : Singleton<ConfettiManager>
{
    /// <summary>
    /// Disables the confetti particle system so that it does not immediately fire
    /// </summary>
    protected override void Awake()
    {
        base.Awake();
        gameObject.SetActive(false);
    }

    /// <summary>
    /// Shoots confetti at the given position
    /// </summary>
    /// <param name="position">The position where the confetti should originate</param>
    public void ShootConfetti(Vector3 position)
    {
        // deactivate the gameobject and activate it again: this re-triggers the particle system
        gameObject.SetActive(false);
        gameObject.transform.position = position;
        gameObject.SetActive(true);
    }
}
