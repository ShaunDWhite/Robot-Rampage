using UnityEngine;
using System.Collections;

public class s_WallMove_19 : MonoBehaviour {

	public bool moveUp, Back;
	public GameObject ControlPanel_4;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
		Back = false;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_4 == null){ 		
			MoveWall_1();
		}
	}
	
	void MoveWall_1(){
		if (moveUp == true) {
			transform.Translate (-(Time.deltaTime + 0.6f), 0, 0);
		}
		
		
		if (transform.position.x <= 64.5) {
			moveUp = false;
		}
		
		
	}
}
