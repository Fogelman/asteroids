﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float speed = 8; // velocidade do jogador
    public float gravity = -9.8f; // valor da gravidade
    public LayerMask groundMask;
    CharacterController character;
    Vector3 velocity;

    bool isGrounded;
    private Animator anim;

    void Start () {
        character = gameObject.GetComponent<CharacterController> ();
        anim = GetComponent<Animator> ();

        if (!GameState.position.Equals (Vector3.zero) && SceneManager.GetActiveScene ().name == "Mars") {
            transform.position = GameState.position;
            GameState.position = Vector3.zero;
            transform.Rotate (Vector3.up * 180);
        }

    }

    void Update () {

        // Verifica se encostando no chão (o centro do objeto deve ser na base)
        isGrounded = Physics.CheckSphere (transform.position, 0.2f, groundMask);

        // Se no chão e descendo, resetar velocidade
        if (isGrounded && velocity.y < 0.0f) {
            velocity.y = -1.0f;
        }

        if (Input.GetKeyDown (KeyCode.Space)) {
            anim.SetTrigger ("dance");
        }

        float x = Input.GetAxis ("Horizontal");
        float z = Input.GetAxis ("Vertical");

        anim.SetFloat ("turn", x);
        anim.SetFloat ("run", z);

        // Rotaciona personagem
        transform.Rotate (0, x * speed * 10 * Time.deltaTime, 0);

        // Move personagem
        Vector3 move = transform.forward * z;
        character.Move (move * Time.deltaTime * speed);

        // Aplica gravidade no personagem
        velocity.y += gravity * Time.deltaTime;
        character.Move (velocity * Time.deltaTime);

    }

    void Damage () {
        GameState.lives -= 1;
        if (GameState.lives <= 0) {
            SceneManager.LoadScene ("GameOver");

        }
    }

}