using UnityEngine;
using System.Collections;

public class s_WallMove_11 : MonoBehaviour {
	public bool moveUp;
	public GameObject ControlPanel_1;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_1 == null){ 		
			MoveWall_11();
		}
	}
	
	void MoveWall_11(){
		if (moveUp == true) {
			transform.Translate (-(Time.deltaTime + 0.5f), 0, 0);
		}
		
		
		if (transform.position.x <= 40) {
			moveUp = false;
		}
	}
}
