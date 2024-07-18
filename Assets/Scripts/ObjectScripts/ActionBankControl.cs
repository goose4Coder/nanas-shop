using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionBankControl : MonoBehaviour, IInitializable
{
    // Start is called before the first frame update
    protected Dictionary<string, InputActionProperty> controlsBank;
    [SerializeField] protected InputActionProperty grabAction;

    public void Initialize(int initializedInOrder)
    {

        controlsBank = new Dictionary<string, InputActionProperty>();
        controlsBank["grabAction"] = grabAction;
    }

    public Dictionary<string, InputActionProperty> GetControls() 
    {
        return controlsBank;
    }
    // Update is called once per frame
}
