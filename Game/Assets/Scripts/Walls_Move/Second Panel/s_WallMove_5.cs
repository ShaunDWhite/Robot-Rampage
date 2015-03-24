using UnityEngine;
using System.Collections;

public class s_WallMove_5 : MonoBehaviour {

	public bool moveUp, Back;
	public GameObject ControlPanel_2, ControlPanel_3 ;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
		Back = false;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_2 == null){ 		
			MoveWall_5();
		}
		if (ControlPanel_3 == null) {
			MoveBack();
			Back = true;
			if (transform.position.x >= 51.8) {
				Back = false;
			}
		}
	}
	
	void MoveWall_5(){
		if (moveUp == true) {
			transform.Translate (0, 0, -(Time.deltaTime + 0.5f));
		}		
		
		if (transform.position.x <= 27) {
			moveUp = false;
		}		
	}

	void MoveBack(){
		if (Back == true) {
			transform.Translate (0, 0, Time.deltaTime + 0.5f);
		}
		//if (transform.position.x >= 51.8) {
		//	Back = false;
		//}
	}
}
