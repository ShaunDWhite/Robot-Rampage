using UnityEngine;
using System.Collections;

public class s_WallMove_7 : MonoBehaviour {

	public bool moveUp;
	public GameObject ControlPanel_2;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_2 == null){ 		
			MoveWall_7();
		}
	}
	
	void MoveWall_7(){
		if (moveUp == true) {
			transform.Translate (-(Time.deltaTime + 0.5f), 0, 0);
		}
		
		
		if (transform.position.x <= -59) {
			moveUp = false;
		}
		
		
	}
}
