using Assets.SimpleLocalization.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// Gère les étapes d'utilisation de la machine.
/// </summary>
public class StepManager : MonoBehaviour
{
    [Header("Texts UI")]
    [Tooltip("Texte affichant le nom de l'étape.")]
    [SerializeField] private TextMeshPro stepNameText;
    
    [Tooltip("Texte affichant la description de l'étape.")]
    [SerializeField] private TextMeshPro descriptionText;
    
    [Header("Buttons UI")]
    [Tooltip("Bouton pour passer à l'étape suivante.")]
    [SerializeField] private GameObject nextButton;
    
    [Tooltip("Bouton pour passer à l'étape précédente.")]
    [SerializeField] private GameObject previousButton;
    
    [Header("Fichier CSV")]
    [Tooltip("Fichier CSV contenant les étapes dans les différentes langues.")]
    [SerializeField] private TextAsset csvFile;
    
    private int currentStepIndex = 1;
    
    private int numberOfSteps;
    
    private void Start()
    {
        string[] lines = csvFile.text.Split('\n');
        numberOfSteps = lines.Length-1;
        UpdateUI();
    }
    
    /// <summary>
    /// Met à jour les textes de l'interface utilisateur.
    /// </summary>
    private void UpdateTextsUI()
    {
        stepNameText.text = "Étape " + currentStepIndex + " sur " + numberOfSteps;
        
        LocalizedTextTMP step = descriptionText.GetComponent<LocalizedTextTMP>();
        string stepKey = step.LocalizationKey;
        
        stepKey = stepKey.Substring(0, stepKey.Length - 1);
        stepKey += currentStepIndex;
        
        step.LocalizationKey = stepKey;
        descriptionText.text = LocalizationManager.Localize(stepKey);
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
        } else if (currentStepIndex == numberOfSteps) {
            nextButton.SetActive(false);
        }
    }
    
    /// <summary>
    /// Met à jour l'interface utilisateur.
    /// </summary>
    private void UpdateUI()
    {
        UpdateTextsUI();
        UpdateButtonUI();
    }
    
    /// <summary>
    /// Permet de passer à l'étape suivante.
    /// </summary>
    public void NextStep()
    {
        if (currentStepIndex < numberOfSteps) {
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
