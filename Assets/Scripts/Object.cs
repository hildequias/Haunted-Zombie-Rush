using UnityEngine;
using System.Collections;

public class Object : MonoBehaviour {

	[SerializeField] private float objectSpeed 	= 1;
	private float resetPosition 				= -13.6f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime));

		if(transform.localPosition.x <= resetPosition) {
			Vector3 newPos = new Vector3(74.20f, transform.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
