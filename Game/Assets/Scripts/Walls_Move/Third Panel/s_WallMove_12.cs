using UnityEngine;
using System.Collections;

public class s_WallMove_12 : MonoBehaviour {

	public bool moveUp;
	public GameObject ControlPanel_3;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_3 == null){ 		
			MoveWall_12();
		}
	}
	
	void MoveWall_12(){
		if (moveUp == true) {
			transform.Translate (-(Time.deltaTime + 0.9f), 0, 0);
		}
		
		
		if (transform.position.x <= -34) {
			moveUp = false;
		}
		
		
	}
}
