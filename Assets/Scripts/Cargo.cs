using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cargo : MonoBehaviour {
    void OnTriggerEnter (Collider other) {
        if (other.CompareTag ("Player")) {
            Vector3 position = transform.position;
            Vector3 player = other.transform.position;

            Vector3 heading = position - player;
            float distance = heading.magnitude;
            Vector3 direction = heading / distance; // This is now the normalized direction.
            direction.y = 0;

            GameState.position = (player - direction * 1.5f);
            SceneManager.LoadScene ("Cargo");
        }
    }
}