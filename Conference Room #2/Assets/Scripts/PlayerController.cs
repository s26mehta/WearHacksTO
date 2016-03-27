using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public Text countText;

	public float movementSpeed = 5.0f;
	public float clockwise = 1000.0f;
	public float counterClockwise = -5.0f;
	private int count;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		count = 200;
		countText.text = "TIMER:" + count.ToString () + " seconds";
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.W)) {
			transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
		}
		else if(Input.GetKey(KeyCode.S)) {
			rb.position += Vector3.back * Time.deltaTime * movementSpeed;
		}
		else if(Input.GetKey(KeyCode.A)) {
			rb.position += Vector3.left * Time.deltaTime * movementSpeed;
		}
		else if(Input.GetKey(KeyCode.D)) {
			rb.position += Vector3.right * Time.deltaTime * movementSpeed;
		}

		transform.Rotate (0, 0, 0);

		if (count >= 1)
			count = count - 1;
		countText.text = "TIMER:" + count.ToString () + " seconds";
	}
}
