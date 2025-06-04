using UnityEngine;

public class PlayerView : MonoBehaviour, IInteraction
{
    Transform rayCastOrigin;
    [SerializeField] Transform mosterTransform;
    bool isLooking;
    IInteraction target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isLooking = false;
        rayCastOrigin = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(rayCastOrigin.position, rayCastOrigin.forward * 10, Color.cyan);
        if (rayCastOrigin != null)
        {
            target?.HitMonster();
        }
    }
    public void HitMonster()
    {

    }

    public void Interact()
    {
        
    }
}
