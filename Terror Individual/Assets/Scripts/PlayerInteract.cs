using UnityEngine;

public class PlayerInteract : MonoBehaviour, IInteraction
{
    Transform rayCastOrigin;
    [SerializeField] float distance;

    public void HitMonster()
    {

    }

    public void Interact()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(rayCastOrigin.position, rayCastOrigin.forward *10 , Color.cyan);
    }
}
