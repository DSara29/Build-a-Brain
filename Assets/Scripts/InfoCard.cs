using UnityEngine;
using UnityEngine.InputSystem;

public class InfoCard : MonoBehaviour
{
    public GameObject PopUp;

    public KeyCode PopUpKey = KeyCode.E; // Key to press for assembly card

    private bool PopUpOpen;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PopUpOpen = PopUp.activeSelf;
    }

    // Update is called once per frame
    void Update()
    {
        //if you press the inventory key it will enable/disable the popup
        if(Input.GetKeyDown(PopUpKey))
        {
            if (PopUpOpen)
            {
                PopUpOpen = false;
                PopUp.SetActive(false);
            }
            else
            {
                PopUpOpen = true;
                PopUp.SetActive(true);
            }
        }
    }
}
