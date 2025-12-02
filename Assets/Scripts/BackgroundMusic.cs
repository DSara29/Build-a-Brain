using Unity.VisualScripting;
using UnityEngine;

public class BackgroundMusic__Script : MonoBehaviour
{
    public static BackgroundMusic__Script instance;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
