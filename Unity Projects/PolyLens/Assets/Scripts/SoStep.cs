using UnityEditor;
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

// Permet d'afficher l'image de l'étape directement dans l'éditeur Unity.
[CustomEditor(typeof(SoStep))]
public class SoStepEditor : Editor
{
    SoStep soStep;

    private void OnEnable()
    {
        soStep = (SoStep)target;
    }
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (soStep.stepImage == null) return;
        
        // Récupère le Sprite de l'étape.
        Texture2D sprite = AssetPreview.GetAssetPreview(soStep.stepImage);
        
        // Définis la taille de l'image.
        GUILayout.Label("", GUILayout.Width(sprite.width), GUILayout.Height(sprite.height));
        
        // Affiche l'image de l'étape.
        GUI.DrawTexture(GUILayoutUtility.GetLastRect(), sprite, ScaleMode.ScaleToFit);
    }
}