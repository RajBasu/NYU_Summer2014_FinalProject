using UnityEngine;
using System.Collections;

public class ScrollingCam : MonoBehaviour {
	// allows for access public to var. which has context
	public float speed = 5f;
	// allows changing speed for additional levels
	public int level = 1;
	// acces too variriable direction 
	public Vector3 direction;
	
	// Use this for initialization
	void Start () {
		//checks position of object 
		Debug.Log (GetComponent<Transform>().position);	
		Debug.Log ("Camera is moving");
	}


	// Update is called once per frame
	void Update () {
		//                             add to sellf ammount         * change in time to adjust for dif. in FPS
		//GetComponent<Transform>().position += new Vector3(1f,1f,0f) * Time.deltaTime * speed;
		// makes the direction a variable that is editable in Unity
		if (GetComponent<Transform>().position.x <= 99f) {
			GetComponent<Transform>().position += direction * Time.deltaTime * speed;
		}
		else 
		Debug.Log ("Camera stopped");
		// need to slowly increase speed as the level continues 
		// need to stop the movement of the thing at the end of the level
		
		// when character or teeth --> touch End cube 
		// > end camera movement 
		// > when teach --> touch exit end level show score 
	}
}
