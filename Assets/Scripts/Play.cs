using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
    void Update () {
        if (Input.GetKeyDown ("space")) {
            PlayGame ();
        }
    }
    void PlayGame () {
        GameState.Restart ();
        SceneManager.LoadScene ("Asteroids");
    }
}