using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Animator myAnim;
    bool myBool;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //myAnim = gameObject.GetComponent<Animator>();
        myBool = false;
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myBool = true;
        }

        else 
        {
            myBool = false;
        }


        if (myBool == false)
        {
            myAnim.SetBool("Interact", false);
        }
        if (myBool == true)
        {
            myAnim.SetBool("Interact", true);
        }
    }
}
