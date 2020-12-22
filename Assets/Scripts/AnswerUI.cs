using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerUI : MonoBehaviour
{
    [System.NonSerialized]
    public Answer answerData;
    public Text description;

    void Start()
    {
        //SetupAnswer();
    }

    void Update()
    {
        
    }

    public void SetupAnswer(Answer _answerData)
    {
        answerData = _answerData;
        description.text = answerData.text;
    }

    public void OnSelectAnswer()
    {
        if (answerData.isEnd)
        {
            Debug.Log("Enhorabuena, has acabado la simulacion :D");
        }
        else
        {
            if (answerData.nextSituation == null)
            {
                Debug.Log("No se ha asignado la siguiente situacion");
            }
            else
            {
                UI_Manager.Instance.ToScreen1(answerData.nextSituation);
            }
        }


        /*
        if (answerData.isCorrect)
        {
            Debug.Log("Es correcto :D");
        }
        else
        {
            Debug.Log("Fallaste wey!");
        }
        //Debug.Log($"AnswerData --> {answerData.name}");
        */
    }
}
