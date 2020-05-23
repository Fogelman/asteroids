// Classe estática para armazenar os estados do jogo entre as fases
using UnityEngine;

public class GameState {
    public static float speed = 1.0f; // Velocidade da simulação (de 1 a 2)
    public static int lives = 3; // Número inicial de vídas
    public static int score = 0;
    public static int maxScore = 0;
    public static int objective = 0;
    public static Vector3 position = Vector3.zero;

    public static void Restart () {
        speed = 1.0f; // Velocidade da simulação (de 1 a 2)
        lives = 3; // Número inicial de vídas
        score = 0;
        maxScore = 0;
        objective = 0;
        position = Vector3.zero;
    }
}