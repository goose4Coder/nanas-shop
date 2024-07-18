using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedPersonQuest : Quest
{
    // Start is called before the first frame update
    protected QuestGiver giver;
    public FixedPersonQuest(string descriptionToSet, QuestGiver giverToSet) :base(descriptionToSet)
    {
        giver = giverToSet;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
