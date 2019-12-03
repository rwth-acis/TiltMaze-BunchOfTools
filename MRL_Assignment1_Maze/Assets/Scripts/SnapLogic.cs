using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;

public class SnapLogic : MonoBehaviour {

    SolverHandler solHan;
	// Use this for initialization
	void Start () {
        solHan = GetComponent<SolverHandler>();
	}
	
	public void switchMode () {
        solHan.enabled = !solHan.enabled;
	}
}
