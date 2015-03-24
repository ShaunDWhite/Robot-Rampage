using UnityEngine;
using System.Collections;

public class s_WallMove_9 : MonoBehaviour {

	public bool moveUp, Back;
	public GameObject ControlPanel_2, ControlPanel_4;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
		Back = false;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_2 == null){ 		
			MoveWall_8();
		}
		if (ControlPanel_4 == null) {
			MoveBack();
			Back = true;
			if(transform.position.x < 52.05){
				Back = false;
			}
		}
	}
	
	void MoveWall_8(){
		if (moveUp == true) {
			transform.Translate (0, 0, Time.deltaTime + 0.9f);
		}		
		if (transform.position.x >= 77) {
			moveUp = false;
		}		
	}

	void MoveBack(){
		if (Back == true) {
			transform.Translate (0, 0, -(Time.deltaTime + 0.9f));
		}
	}



}
