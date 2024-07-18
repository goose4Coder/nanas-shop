using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Quest
{
    // Start is called before the first frame update
    protected string description;
    protected string potion;
    protected uint reward;

    public Quest(string descriptionToSet)
    {
        this.description = descriptionToSet;
        potion = "";
        reward = 0;
    }
    virtual public QuestGiver GetGiver()
    {
        return new QuestGiver("Nana");
    }

    virtual public string GetDescription()
    {
        return description.Replace("[Potion]", potion);
    }
}
