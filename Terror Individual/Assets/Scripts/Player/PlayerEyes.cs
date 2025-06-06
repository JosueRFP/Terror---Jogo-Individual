using UnityEngine;
using System.Collections;

public class PlayerEyes : MonoBehaviour
{
    [SerializeField] float blinkTime;
    [SerializeField] GameObject blinkImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Blink());
    }

    // Update is called once per frame
    void Update()
    {

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
}
