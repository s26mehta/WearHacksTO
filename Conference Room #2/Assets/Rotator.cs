using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	int timer = 0;
	int direction = 1;

	// Update is called once per frame
	void Update () {
		if (timer % 50 == 0)
			direction *= -1;
		
		transform.Rotate (new Vector3 (0, 1 * direction, 0));
		timer++;
		//transform.Rotate (new Vector2 (10, 10));
	}

}
