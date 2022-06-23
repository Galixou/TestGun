using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionDistance;

    public TextMeshProUGUI interactionText;
    //public GameObject interactionHoldGO; // the ui parent to disable when not interacting
    //public Image interactionHoldProgress; // the progress bar for hold interaction type

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit hit;

        bool successfulHit = false;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                HandleInteraction(interactable);
                interactionText.text = interactable.GetDescription();
                successfulHit = true;

                //interactionHoldGO.SetActive(interactable.type == Interactable.InteractionType.Hold);
            }
        }

        if (!successfulHit)
        {
            interactionText.text = "";
            //interactionHoldGO.SetActive(false);
        }
    }

    void HandleInteraction(Interactable interactable)
    {
        switch (interactable.type)
        {
            case Interactable.InteractionType.Click:
                if (Input.GetButton("Interact"))
                {
                    interactable.Interact();
                }
                break;

            case Interactable.InteractionType.Hold:
                if (Input.GetButton("Interact"))
                {
                    // we are holding the key, increase the timer until we reach 1f
                    interactable.IncreaseHoldTime();
                    if (interactable.GetHoldTime() > 1f) 
                    {
                        interactable.Interact();
                        interactable.ResetHoldTime();
                    }
                }
                else
                {
                    interactable.ResetHoldTime();
                }
                //interactionHoldProgress.fillAmount = interactable.GetHoldTime();
                break;
                // here is started code for your custom interaction :)
            case Interactable.InteractionType.Minigame:
                // here you make ur minigame appear
                break;

                // helpful error for us in the future
            default:
                throw new System.Exception("Unsupported type of interactable.");
        }
    }
}