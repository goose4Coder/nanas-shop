using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface IInitializable
{
    // Start is called before the first frame update
    public void Initialize(int initializedInOrder);
    //{

    //    Debug.Log("No defined init interface at: " + initializedInOrder.ToString());
    //}

}