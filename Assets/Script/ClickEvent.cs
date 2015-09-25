using UnityEngine;
using System.Collections;

public class ClickEvent : MonoBehaviour {

	public GameObject MemoryA;

	// Use this for initialization
	void Start () {
	
	}

	public void OnMouseDown()
	{
		MemoryA.SetActive(true);

	}

	public void OnMouseUp()
	{
		MemoryA.SetActive(false);
		
	}
	// Update is called once per frame
	void Update () {

	
	}
}
