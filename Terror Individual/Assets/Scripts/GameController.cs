using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    [SerializeField] static GameController instance;
    public UnityEvent OnBlink, OnEyesOpen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
