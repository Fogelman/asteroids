using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cargo : MonoBehaviour {
    void OnTriggerEnter (Collider other) {

        Debug.Log (other.name);
        if (other.CompareTag ("Player")) {
            SceneManager.LoadScene ("Cargo");
        }
    }
}