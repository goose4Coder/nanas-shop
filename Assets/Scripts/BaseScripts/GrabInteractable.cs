using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrabInteractable : MonoBehaviour, IControlInit
{
    // Start is called before the first frame update
    protected InputActionProperty grabAction;

    public void InitControls(Dictionary<string, InputActionProperty> controls, int initializedInOrder)
    {
        grabAction = controls["grabAction"];
    }

    protected virtual void GrabInteract()
    {
        
    }

    protected virtual void UngrabInteract()
    {

    }
    private void OnTriggerEnter(Collider colliding)
    {
        if (grabAction.action.IsPressed()&&colliding.gameObject.name=="Direct Interactor")
        {
            GrabInteract();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        UngrabInteract();
    }
    private void Update()
    {
        if (grabAction.action.WasReleasedThisFrame() == false)
        {
            UngrabInteract();
        }
    }
}