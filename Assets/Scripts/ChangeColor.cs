using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    /// <summary>
    /// Change la couleur de l'objet pour la couleur passée en paramètre.
    /// </summary>
    /// <param name="color">Couleur</param>
    private void ChangeToColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    } 
    
    public void ChangeToRed()
    {
        ChangeToColor(Color.red);
    }
    
    public void ChangeToGreen()
    {
        ChangeToColor(Color.green);
    }
    
    public void ChangeToBlue()
    {
        ChangeToColor(Color.blue);
    }
    
    public void ChangeToYellow()
    {
        ChangeToColor(Color.yellow);
    }
}
