using TMPro;
using UnityEngine;

public class BasketHoop : MonoBehaviour
{
    [SerializeField] private TextMeshPro scoreText;
    private int score = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) {
            IncreaseScore();
        }
    }
    
    /// <summary>
    /// Augmente le score de 1 et met à jour le texte du score.
    /// </summary>
    private void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
