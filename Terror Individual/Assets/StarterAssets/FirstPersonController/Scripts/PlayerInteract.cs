using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    Transform rayCastOrigin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rayCastOrigin = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(rayCastOrigin.position, rayCastOrigin.forward * 5, Color.green);
    }
}
