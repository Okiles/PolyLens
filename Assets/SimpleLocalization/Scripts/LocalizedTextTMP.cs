using TMPro;
using UnityEngine;

namespace Assets.SimpleLocalization.Scripts
{
    /// <summary>
    /// Localize text component.
    /// </summary>
    [RequireComponent(typeof(TMP_Text))]
    public class LocalizedTextTMP : MonoBehaviour
    {
        public string LocalizationKey;

        public void Start()
        {
            Localize();
            LocalizationManager.OnLocalizationChanged += Localize;
        }

        public void OnDestroy()
        {
            LocalizationManager.OnLocalizationChanged -= Localize;
        }

        public void Localize()
        {
            TMP_Text textMesh = GetComponent<TMP_Text>();
            switch (LocalizationManager.Language)
            {
                case "Chinese":
                    textMesh.font = MultiLangage.instance.chineseFont;
                    break;
                case "Japanese":
                    textMesh.font = MultiLangage.instance.japaneseFont;
                    break;
                case "Arabic":
                    textMesh.font = MultiLangage.instance.arabicFont;
                    break;
                default:
                    textMesh.font = MultiLangage.instance.defaultFont;
                    break;
            }
            textMesh.text = LocalizationManager.Localize(LocalizationKey);
            
        }
    }
}