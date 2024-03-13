using UnityEngine;

/// <summary>
/// Objet qui suit les lois de la gravité et qui retourne à sa position initiale lorsqu'il traverse le sol (KillBox).
/// </summary>
public class ObjectGravity : MonoBehaviour
{
    /// <summary>
    /// La position initiale de l'objet.
    /// </summary>
    private Vector3 initialPosition;
    
    void Start()
    {
        initialPosition = transform.position;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillBox")) {
            ReturnToInitialPosition();
        }
    }
    
    /// <summary>
    /// Retourne l'objet à sa position initiale.
    /// </summary>
    private void ReturnToInitialPosition()
    {
        transform.position = initialPosition;
        // Stop le mouvement de l'objet.
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
