using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointCollider : MonoBehaviour {
	private bool isNext = false;
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player")
			isNext = true;
	}
}
