using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victorine : MonoBehaviour
{
    public QuestionList[] Questions;
    public Text qText;

    public void OnClickPlay()
    {

    }
}

[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answers = new string[3];
}
