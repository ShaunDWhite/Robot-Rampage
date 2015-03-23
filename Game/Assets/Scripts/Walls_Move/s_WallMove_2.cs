using UnityEngine;
using System.Collections;

public class s_WallMove_2 : MonoBehaviour {

	public bool moveUp;
	public GameObject ControlPanel_1;
	
	// Use this for initialization
	void Start () {
		moveUp = true;
	}
	
	//Update is called once per frame
	void Update () {
		if(ControlPanel_1 == null){ 		
			MoveWall_2();
		}
	}
	
	void MoveWall_2(){
		if (moveUp == true) {
			transform.Translate (0, 0, Time.deltaTime + 0.5f);
		}		
		if (transform.position.x >= -47) {
			moveUp = false;
		}		
	}
}
