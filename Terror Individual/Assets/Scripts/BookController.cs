using UnityEngine;
using System.Collections;
using TMPro;


public class BookController : MonoBehaviour
{
    [SerializeField] GameObject endGame;
    [SerializeField] TextMeshProUGUI booksTxt;
    
    float booksQtd = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateBooksCount();
    }

    public void GetBook()
    {
        booksQtd--;
        UpdateBooksCount();

    }

    void UpdateBooksCount()
    {
        
    }

  
}
