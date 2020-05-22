using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartScript : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        int children = gameObject.transform.childCount;
        for (int i = 0; i < children; i++) {
            // SpriteRenderer renderer = gameObject.transform.GetChild (i).gameObject.GetComponent<SpriteRenderer> ();

            Image heart = gameObject.transform.GetChild (i).gameObject.GetComponent<Image> ();

            if (i < GameState.lives) {
                heart.color = Color.red;
            } else {
                heart.color = Color.grey;

            }

        }
    }
}