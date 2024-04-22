using TMPro;
using UnityEngine;

/// <summary>
/// Gère les étapes d'utilisation de la machine.
/// </summary>
public class StepManager : MonoBehaviour
{
    [Header("Texts UI")]
    [Tooltip("Texte affichant le titre de l'étape.")]
    [SerializeField] private TextMeshPro titleText;
    
    [Tooltip("Texte affichant la description de l'étape.")]
    [SerializeField] private TextMeshPro descriptionText;
    
    [Tooltip("Image affichant l'image de l'étape.")]
    [SerializeField] private SpriteRenderer imageRenderer;
    
    [Header("Buttons UI")]
    [Tooltip("Bouton pour passer à l'étape suivante.")]
    [SerializeField] private GameObject nextButton;
    
    [Tooltip("Bouton pour passer à l'étape précédente.")]
    [SerializeField] private GameObject previousButton;
    
    [Header("Step List")]
    [Tooltip("Liste d'affichage des étapes (animations).")]
    [SerializeField] private GameObject[] stepAnimation;
    
    [Tooltip("Etapes de la machine.")]
    [SerializeField] private SoStep[] steps;
    
    private int currentStepIndex = 1;
    
    private void Start()
    {
        UpdateUI();
    }
    
    /// <summary>
    /// Met à jour les textes de l'interface utilisateur.
    /// </summary>
    private void UpdateTextsUI()
    {
        titleText.text = "Étape " + currentStepIndex + " sur " + steps.Length;
        descriptionText.text = steps[currentStepIndex - 1].stepText;
        if (steps[currentStepIndex - 1].stepImage != null) {
            imageRenderer.sprite = steps[currentStepIndex - 1].stepImage;
        }
    }

    /// <summary>
    /// Met à jour l'affichage des boutons de l'interface utilisateur.
    /// </summary>
    private void UpdateButtonUI()
    {
        previousButton.SetActive(true);
        nextButton.SetActive(true);
        
        if (currentStepIndex == 1) {
            previousButton.SetActive(false);
        } else if (currentStepIndex == steps.Length) {
            nextButton.SetActive(false);
        }
    }
    
    /// <summary>
    /// Met à jour l'affichage des gameobjects.
    /// </summary>
    private void UpdateGameObjects()
    {
        foreach (GameObject go in stepAnimation) {
            go.SetActive(false);
        }
        
        stepAnimation[currentStepIndex - 1].SetActive(true);
    }
    
    /// <summary>
    /// Met à jour l'interface utilisateur.
    /// </summary>
    private void UpdateUI()
    {
        UpdateTextsUI();
        UpdateButtonUI();
        UpdateGameObjects();
    }
    
    /// <summary>
    /// Permet de passer à l'étape suivante.
    /// </summary>
    public void NextStep()
    {
        if (currentStepIndex < steps.Length) {
            currentStepIndex++;
            UpdateUI();
        }
    }
    
    /// <summary>
    /// Permet de passer à l'étape précédente.
    /// </summary>
    public void PreviousStep()
    {
        if (currentStepIndex > 0) {
            currentStepIndex--;
            UpdateUI();
        }
    }
}
