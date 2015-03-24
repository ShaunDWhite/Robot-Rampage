using UnityEngine;
using System.Collections;

public class s_WinScreenAudio : MonoBehaviour {

	public AudioClip Yay;
	
	// Use this for initialization
	void Start () {
		Camera.main.audio.clip = Yay;		
		Camera.main.audio.Play();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
