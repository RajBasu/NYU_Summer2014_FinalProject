using UnityEngine;
using System.Collections;

public class KillBox : MonoBehaviour {

	
	void OnTriggerEnter ( Collider player ) {
		Destroy ( player.gameObject );
	}
}
