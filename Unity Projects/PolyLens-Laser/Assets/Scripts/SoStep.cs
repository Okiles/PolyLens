using UnityEngine;

[CreateAssetMenu(fileName = "New Step", menuName = "Step")]
public class SoStep : ScriptableObject
{
    [Tooltip("Description de l'étape.")]
    [TextArea(5, 10)]
    public string stepText;
    
    [Tooltip("Image de l'étape.")]
    public Sprite stepImage;
}

