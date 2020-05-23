using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
    void OnTriggerEnter (Collider other) {
        if (other.CompareTag ("Player")) {
            SceneManager.LoadScene ("GameOver");
        }
    }
}