using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.Events;


public class BookController : MonoBehaviour
{
    [SerializeField] UnityEvent OnEndGame;
    [SerializeField] string sceneName;
    public List<GameObject> books = new List<GameObject>();
    [SerializeField] TextMeshProUGUI booksTxt;
    
    float booksQtd, distance;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        booksQtd = books.Count;
    }

    

    public void GetBook()
    {
        
    }

    public void UpdateBooksCount()
    {
        booksQtd--;
        if (booksQtd <= 0)
        {
            
           
        }
    }
}
