using UnityEngine;
using System.Collections;

public class s_WallMove_3 : MonoBehaviour {

	public bool moveUp, Back;
	public GameObject ControlPanel_1, ControlPanel_4;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
		Back = false;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_1 == null){ 		
			MoveWall_3();
		}
		if (ControlPanel_4 == null) {
			MoveBack();
			Back = true;
			if(transform.position.z > -44.5){
				Back = false;
			}
		}
	}
	
	void MoveWall_3(){
		if (moveUp == true) {
			transform.Translate (Time.deltaTime + 0.9f, 0, 0);
		}		
		if (transform.position.z <= -69) {
			moveUp = false;
		}	
	}
	
	void MoveBack(){
		if (Back == true) {
			transform.Translate (-(Time.deltaTime + 0.9f), 0, 0);
		}
	}

}
