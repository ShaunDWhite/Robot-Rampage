using UnityEngine;
using System.Collections;

public class s_WallMove_1 : MonoBehaviour {

	public bool moveUp;
	public GameObject ControlPanel_1;

	// Use this for initialization
	void Start () {
		moveUp = true;
	}
	
	 //Update is called once per frame
	void Update () {
	if(ControlPanel_1 == null){ 		
			MoveWall_1();
		}
	}

	void MoveWall_1(){
		if (moveUp == true) {
			transform.Translate (0, 0, Time.deltaTime + 0.6f);
		}

		
		if (transform.position.x >= 27) {
				moveUp = false;
		}


	}
}