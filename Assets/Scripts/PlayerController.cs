using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float movementSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {
			transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
		}
		else if (Input.GetKey (KeyCode.D)) {
			rb.position += Vector3.back * Time.deltaTime * movementSpeed;
		}
		else if (Input.GetKey (KeyCode.S)) {
			rb.position += Vector3.left * Time.deltaTime * movementSpeed;
		}
		else if (Input.GetKey (KeyCode.W)) {
			rb.position += Vector3.right * Time.deltaTime * movementSpeed;
		}



	}
}
