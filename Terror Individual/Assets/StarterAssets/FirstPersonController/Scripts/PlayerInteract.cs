using UnityEngine;

public class PlayerInteract : MonoBehaviour, IInteraction
{
    Transform rayCastOrigin;

    public void Hit()
    {
        
    }

    public void Interact()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rayCastOrigin = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(rayCastOrigin.position, rayCastOrigin.forward * 5);
    }
}
