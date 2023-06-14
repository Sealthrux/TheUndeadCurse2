using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Objective : MonoBehaviour
{
    public string Text1;
    public string Text2;
    public TMP_Text ObjectiveText;
    public TMP_Text ObjectiveCounter;
    public float MaxObjective;
    public float CurrentObjective = 0;


    public void Start()
    {
        

    }
    public void Update()
    {

        Text1 = "Consume " + MaxObjective + " human meat";
        Text2 = CurrentObjective + "/" + MaxObjective;

        ObjectiveText.text = Text1;
        ObjectiveCounter.text = Text2;
    }

    public void ObjectiveCheckpoint()
    {
        
        if (CurrentObjective >= MaxObjective) 
        {
            CurrentObjective = MaxObjective;
        }

        else
        {
            CurrentObjective++;
        }
    }

    public bool ObjectiveComplete()
    {
        if (CurrentObjective >= MaxObjective)
        {
            return true;
        }
        else return false;
    }
}
