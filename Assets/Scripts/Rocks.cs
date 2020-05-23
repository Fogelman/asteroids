using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocks : MonoBehaviour {
    void OnTriggerEnter (Collider other) {

        if (other.CompareTag ("Player")) {
            GameState.objective += 1;

            Destroy (gameObject);
        }
    }
}