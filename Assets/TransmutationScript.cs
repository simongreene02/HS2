using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmutationScript : MonoBehaviour {

	public GameObject cube;
	private bool hasBeenClicked = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.GetComponent<MeshRenderer> ().enabled = !hasBeenClicked;
		cube.gameObject.GetComponent<MeshRenderer> ().enabled = hasBeenClicked;
	}

	public void OnBeingClicked() {
		hasBeenClicked = true;
	}
}
