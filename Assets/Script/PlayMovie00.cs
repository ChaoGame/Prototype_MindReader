using UnityEngine;
using System.Collections;

public class PlayMovie00 : MonoBehaviour {

	public MovieTexture movie00;


	// Use this for initialization
	void Start () {
		movie00.loop = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Mouse0)) 
		{
			//((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
			movie00.Play ();
		}
		//if (Input.GetKeyUp (KeyCode.Mouse0)) {
		
		//	movie00.Pause();
		//}
	
	}
}
