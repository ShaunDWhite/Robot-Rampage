using UnityEngine;
using System.Collections;

public class s_LaserWall : MonoBehaviour {

	public GameObject ControlPanel_1, ControlPanel_2, ControlPanel_3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if((ControlPanel_1 == null) && (ControlPanel_2 == null) && (ControlPanel_3 == null)){
			Destroy(gameObject);
			print ("Boom");
		}
	
	}
}
