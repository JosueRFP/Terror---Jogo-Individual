using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject creditsPainel;
    [SerializeField] string sceneName;
    
    public void Teleport()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenCreditsBTN()
    {
        creditsPainel.SetActive(true);
    }
    public void CloseCreditsBTN() 
    { 
        creditsPainel?.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        print("Saiu do jogo");
    }
}
