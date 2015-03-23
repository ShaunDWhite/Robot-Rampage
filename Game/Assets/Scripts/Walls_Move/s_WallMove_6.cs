using UnityEngine;
using System.Collections;

public class s_WallMove_6 : MonoBehaviour {

	public bool moveUp;
	public GameObject ControlPanel_2;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_2 == null){ 		
			MoveWall_6();
		}
	}
	
	void MoveWall_6(){
		if (moveUp == true) {
			transform.Translate (0, 0, -(Time.deltaTime + 0.5f));
		}
		
		
		if (transform.position.x <= 3.5) {
			moveUp = false;
		}
		
		
	}
}
