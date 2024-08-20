using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class QuestBankControl : MonoBehaviour, IInitializable
{
    // Start is called before the first frame update
    protected List<Quest> quests;
    public void Initialize(int initializedInOrder)
    {
        quests = new List<Quest>();
        TextAsset dialogueFile = (TextAsset)Resources.Load("Quests/QuestList");
        XmlDocument questXML = new XmlDocument();
        questXML.LoadXml(dialogueFile.text);
        XmlNodeList nodes = questXML.FirstChild.ChildNodes;
        foreach (XmlNode targetNode in nodes)
        {
            switch (targetNode.Attributes.GetNamedItem("questType").Value)
            {
                case "FixedPersonSimpleQuest":
                    quests.Add(new FixedPersonQuest(targetNode.Attributes.GetNamedItem("Description").Value, targetNode.Attributes.GetNamedItem("PotionName").Value, new QuestGiver(targetNode.Attributes.GetNamedItem("GiverName").Value)));

                    break;
                default:
                    break;
            }
        }
    }

    public List<Quest> GetQuests()
    {
        return quests;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
