using UnityEngine;

public class NumberGenerator : MonoBehaviour    
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void interact() 
    {
        Debug.Log(Random.Range(0,100));
        Debug.Log("It works");
    }
}
