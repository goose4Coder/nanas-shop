using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedPersonQuest : Quest
{
    // Start is called before the first frame update
    protected QuestGiver giver;
    public FixedPersonQuest(string descriptionToSet, string potionToSet, QuestGiver giverToSet) :base(descriptionToSet, potionToSet)
    {
        giver = giverToSet;
    }

    public override QuestGiver GetGiver()
    {
        return giver;
    }


    // Update is called once per frame

}
