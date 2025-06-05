using UnityEngine;

public enum PlayerSaw
{
    Blink, OpenEyes
}

public class PlayerView : MonoBehaviour, IInteraction
{
    [SerializeField] float distance;
    Transform rayCastOrigin;
    PlayerSaw saw;

   

    void Start()
    {
        Debug.DrawRay(rayCastOrigin.position, rayCastOrigin.forward * 10, Color.cyan);
    }


    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && rayCastOrigin != null)
        {
            
        }
    }
    public void Interact()
    {

    }

}
