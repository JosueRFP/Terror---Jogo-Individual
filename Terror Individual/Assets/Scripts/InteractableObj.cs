using UnityEngine;

public class InteractableObj : MonoBehaviour, IInteraction
{
    public void Interact()
    {
        Destroy(gameObject);
    }
}
