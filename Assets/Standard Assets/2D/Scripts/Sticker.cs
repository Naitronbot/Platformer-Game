using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticker : MonoBehaviour {
    public GameObject PlayerCharacter;
	
	private void OnCollisionEnter2D(Collision2D thing) {
		if (thing.gameObject == PlayerCharacter) {
			PlayerCharacter.transform.parent = transform;
		}
	}
	
	private void OnCollisionExit2D(Collision2D thing) {
		if (thing.gameObject == PlayerCharacter) {
			PlayerCharacter.transform.parent = null;
		}
	}
}