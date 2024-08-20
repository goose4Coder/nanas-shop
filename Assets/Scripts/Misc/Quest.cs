using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Quest
{
    // Start is called before the first frame update
    protected string description;
    protected string potionName;
    protected uint reward;

    public Quest(string descriptionToSet, string potionToSet)
    {
        this.description = descriptionToSet;
        potionName = potionToSet;
        reward = 0;
    }
    virtual public QuestGiver GetGiver()
    {
        return new QuestGiver("Nana");
    }

    virtual public string GetDescription()
    {
        return description.Replace("[Potion]", potionName);
    }
}
