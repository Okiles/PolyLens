using UnityEngine;

/// <summary>
/// Gère les scènes de l'application.
/// </summary>
public class SceneManager : MonoBehaviour
{
    /// <summary>
    /// Rafraîchit la scène actuelle.
    /// </summary>
    public void Refresh()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
    
    /// <summary>
    /// Charge la scène du menu principal.
    /// </summary>
    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Hub");
    }
    
    /// <summary>
    /// Charge la scène dont le nom est passé en paramètre.
    /// </summary>
    /// <param name="sceneName">Nom de la scène à charger</param>
    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}