using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Points : MonoBehaviour {
    void Start () {
        gameObject.GetComponent<Text> ().text = GameState.objective.ToString () + " ROCKS COLLECTED";
    }

}