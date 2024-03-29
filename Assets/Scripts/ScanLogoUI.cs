using UnityEngine;

public class ScanLogoUI : MonoBehaviour
{
    public void DisplayUI(Canvas canvas)
    {
        canvas.gameObject.SetActive(true);
    }
    
    public void HideUI(Canvas canvas)
    {
        canvas.gameObject.SetActive(false);
    }
}
