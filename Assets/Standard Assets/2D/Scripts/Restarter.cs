using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D {
    public class Restarter : MonoBehaviour {
		public GameObject PlayerCharacter;
		public GameObject Checkpoint1;
		public GameObject Checkpoint2;
		private static bool checkpointReached = false;
		
        private void OnTriggerEnter2D(Collider2D other) {			
            if (other.tag == "Player" && this.tag == "Checkpoint") {
				checkpointReached = true;
			} else if (other.tag == "Player" && !checkpointReached) {
                PlayerCharacter.transform.position = Checkpoint1.transform.position;
            } else if (other.tag == "Player" && checkpointReached) {
                PlayerCharacter.transform.position = Checkpoint2.transform.position;
			} 
        }
    }
}
