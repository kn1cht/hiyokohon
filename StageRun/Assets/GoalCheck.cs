using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheck : MonoBehaviour {
	public static bool goal;

	void Start() { goal = false; }

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Player") { goal = true; }
	}
}
