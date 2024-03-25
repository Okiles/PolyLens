using Assets.SimpleLocalization.Scripts;
using TMPro;
using UnityEngine;

public class MultiLangageManager : MonoBehaviour
{
    // On importe les différentes polices d'écriture
    public TMP_FontAsset defaultFont;
    public TMP_FontAsset japaneseFont;
    public TMP_FontAsset arabicFont;
    public TMP_FontAsset chineseFont;

    // On crée une instance de MultiLangageManager
    public static MultiLangageManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        // On récupère la langue du système
        LocalizationManager.Read();
        
        
        // On change la langue en fonction de la langue du système
        switch (Application.systemLanguage)
        {
            case SystemLanguage.German:
                LocalizationManager.Language = "German";
                break;
            case SystemLanguage.Japanese:
                LocalizationManager.Language = "Japanese";
                break;
            case SystemLanguage.French:
                LocalizationManager.Language = "French";
                break;
            case SystemLanguage.Spanish:
                LocalizationManager.Language = "Spanish";
                break;
            case SystemLanguage.Arabic:
                LocalizationManager.Language = "Arabic";
                break;
            case SystemLanguage.Chinese:
                LocalizationManager.Language = "Chinese";
                break;
            case SystemLanguage.Italian:
                LocalizationManager.Language = "Italian";
                break;
            case SystemLanguage.Ukrainian:
                LocalizationManager.Language = "Ukrainian";
                break;
            case SystemLanguage.English:
                LocalizationManager.Language = "English";
                break;
            default:
                // Si la langue du système n'est pas reconnue, on met la langue en anglais
                LocalizationManager.Language = "English";
                break;
        }
        
    }
    
    // On crée une fonction pour changer la langue
    public void SetLocalization(string localization)
    {
        LocalizationManager.Language = localization;
    }
}
