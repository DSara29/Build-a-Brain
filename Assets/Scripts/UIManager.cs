using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   
   public void QuitGame()
    {
        Debug.Log("The application has quit");
        Application.Quit();
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
