using UnityEngine;

public class LFL_Animate : MonoBehaviour
{
    public Animator allAnimation;
    private bool myBool;

    void Start()
    {
        myBool = false;
        gameObject.tag = "Left Frontal Lobe";
    }

    void Update()
    {
        // Click detection on THIS object
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)   // <-- THIS object clicked
                {
                    myBool = true;
                    allAnimation.SetBool("Interact", true);
                    interact();
                }
                else
                {
                    myBool = false;
                    allAnimation.SetBool("Interact", false);
                }
            }
        }
    }

    public void interact()
    {
        Debug.Log(Random.Range(0, 100));
        Debug.Log("It works");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Left Frontal Lobe"))
        {
            Debug.Log("Triggered by Click");
        }
    }
}
