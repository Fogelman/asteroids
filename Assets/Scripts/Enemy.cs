using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;

    void Start () {
        agent = GetComponent<NavMeshAgent> ();
    }
    void Update () {
        agent.SetDestination (target.transform.position);
    }

    void OnTriggerEnter (Collider other) {

        if (other.gameObject.layer != LayerMask.NameToLayer ("Player")) {
            return;
        }
        other.gameObject.SendMessage ("Damage");
    }

}