using UnityEngine;

interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float Interactrange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, Interactrange))
            {
                //Debug.Log("sdfkjsdf");
                //hitInfo.collider.gameObject.TryGetComponent<NumberGenerator>().interact();
                if (hitInfo.collider.gameObject.TryGetComponent(out LTL_Animate interactObj))
                {
                    interactObj.interact();
                }
            }
        }
    }
}
