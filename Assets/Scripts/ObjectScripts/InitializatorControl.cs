using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializatorControl : MonoBehaviour
{
    // Start is called before the first frame update
    protected List<IInitializable> toInitialize;
    protected List<IControlInit> toControlInit;
    [SerializeField] protected string additionalObjectsToLoad = "";
    protected GameObject actionBank;
    protected class HollowInitializable : IInitializable
    {
        public virtual void Initialize(int initializedInOrder)
        {

            Debug.Log("Not IInitializable: " + initializedInOrder.ToString());
        }

    }
    protected void PrepareDefaultObjects()
    {
        
        toInitialize.Add(GameObject.Find("ActionBank").GetComponent<ActionBankControl>());

    }

    protected void PrepareAdditionalObjects()
    {
        string[] splitted = this.additionalObjectsToLoad.Split(";");
        foreach (string objectToLoad in splitted)
        {
            try
            {
                toInitialize.Add(GameObject.Find(objectToLoad).GetComponent<IInitializable>());
            }
            catch
            {
                Debug.Log("Hollow");
                toInitialize.Add(new HollowInitializable());
            }
        }

    }

    protected void InitializeObjects()
    {
        
        for (int i = 0; i < this.toInitialize.Count; i++)
        {
            Debug.Log(toInitialize.ToString());
            toInitialize[i].Initialize(i);
        }
        for (int i = 0; i < this.toControlInit.Count; i++)
        {
            Debug.Log(toControlInit.ToString());
            toControlInit[i].InitControls(GameObject.Find("ActionBank").GetComponent<ActionBankControl>().GetControls(), i);
        }
    }

    void Start()
    {
        toInitialize = new List<IInitializable>();
        toControlInit = new List<IControlInit>();
        PrepareDefaultObjects();
        //PrepareAdditionalObjects();
        InitializeObjects();

    }
}