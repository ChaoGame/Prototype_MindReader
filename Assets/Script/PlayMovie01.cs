using UnityEngine;
using System.Collections;

public class PlayMovie01 : MonoBehaviour {
	public MovieTexture movie01;

	// Use this for initialization
	void Start () {
		movie01.loop = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.JoystickButton1)) 
		{
			movie01.Play();
			//((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
		}

		if (Input.GetKeyUp (KeyCode.JoystickButton1)) {
			
			movie01.Pause();
		}
	}
}
