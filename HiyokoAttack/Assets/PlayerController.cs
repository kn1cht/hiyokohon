using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 8f;
	public float moveableRange = 5.5f;

	void Update() {
		transform.Translate(Input.GetAxisRaw ("Horizontal") * speed * Time.deltaTime, 0, 0);
		transform.position = new Vector2(
			Mathf.Clamp(transform.position.x, -moveableRange, moveableRange),
			transform.position.y
		);
	}
}
