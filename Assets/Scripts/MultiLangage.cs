using System;
using System.Collections;
using System.Collections.Generic;
using Assets.SimpleLocalization.Scripts;
using TMPro;
using UnityEngine;

public class MultiLangage : MonoBehaviour
{
    public TMP_FontAsset defaultFont;
    public TMP_FontAsset japaneseFont;
    public TMP_FontAsset arabicFont;
    public TMP_FontAsset chineseFont;

    public static MultiLangage instance;
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
        LocalizationManager.Read();

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
                LocalizationManager.Language = "English";
                break;
        }
        
    }
    
    public void SetLocalization(string localization)
    {
        LocalizationManager.Language = localization;
    }
}
