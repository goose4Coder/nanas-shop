using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface IControlInit
{
    // Start is called before the first frame update

    public void InitControls(Dictionary<string, InputActionProperty> controls, int initializedInOrder);
}
