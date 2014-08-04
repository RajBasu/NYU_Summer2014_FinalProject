using UnityEngine;
using System.Collections;

public class scorez : MonoBehaviour {
	public Transform seed; 

	void OnTriggerEnter ( Collider player ){
		Destroy (seed.gameObject ); 
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
