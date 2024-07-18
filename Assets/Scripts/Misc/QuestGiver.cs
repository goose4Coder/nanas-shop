using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver
{
    // Start is called before the first frame update
    protected string name;


    public QuestGiver(string nameToSet) {  this.name = nameToSet; }
    public string GetName() { return name; }

}
