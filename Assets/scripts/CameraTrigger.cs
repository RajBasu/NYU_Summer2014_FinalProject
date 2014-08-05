using UnityEngine;
using System.Collections;

public class CameraTrigger : MonoBehaviour {



	public GameObject stopper;
	public Transform Cam; //assign in unity inspector
	public Transform Door; //assign in unity inspector
	
	// you will need a trigger-collider on this object
	void OnTriggerEnter (Collider stopper) {
		Cam.parent = stopper.transform;
	}
	
	
}
