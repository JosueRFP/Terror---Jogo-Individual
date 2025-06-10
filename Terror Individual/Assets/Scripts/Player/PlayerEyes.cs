using UnityEngine;
using System.Collections;


public class PlayerEyes : MonoBehaviour, ISeeYou
{
    Transform rayCast;
    [SerializeField] float blinkTime;
    [SerializeField] GameObject blinkImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rayCast = Camera.main.transform;
        StartCoroutine(Blink());
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.DrawRay(rayCast.position, rayCast.forward * 10, Color.red);
    }

    private void FixedUpdate()
    {
        
    }
    IEnumerator Blink()
    {
        yield return new WaitForSeconds(7);
        blinkImage.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(Blink());
        blinkImage.SetActive(false);
        
    }

    public void HitMonster()
    {

    }
}
