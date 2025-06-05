using System.Collections;
using UnityEngine;

public enum PlayerSaw
{
    Blink, OpenEyes
}

public class PlayerView : MonoBehaviour, IInteraction
{
    [SerializeField] float blinkColdown;
    [SerializeField] float distance;
    Transform rayCastOrigin;
    PlayerSaw saw;

   

    void Start()
    {
        PlayerEyes(PlayerSaw.OpenEyes);
        Debug.DrawRay(rayCastOrigin.position, rayCastOrigin.forward * 10, Color.cyan);
    }


    private void Update()
    {        
        if (rayCastOrigin != null)
        {
            Interact();
        }
        else { }
    }
    public void Interact()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gameObject.SetActive(true);

        }
    }

    private  void PlayerEyes(PlayerSaw vison)
    {
        switch (vison)
        {
            case PlayerSaw.OpenEyes:
                break;
            case PlayerSaw.Blink:
                StartCoroutine(BlinkTime());
                print("Piscou");
                break;
        }
    }

    IEnumerator BlinkTime()
    {
        blinkColdown++;
        if (blinkColdown == 7)
        {
            blinkColdown = 0;
            yield return new WaitForSeconds(blinkColdown);
        }
    }

}
