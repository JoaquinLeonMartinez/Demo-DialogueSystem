using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionUI : MonoBehaviour
{
    public Text description;
    public Button[] answers;
    [System.NonSerialized]
    public Question questionData;

    void Start()
    {
        //answers = new Button[4];
    }


    void Update()
    {
        
    }

    public void SetupQuestion()
    {
        description.text = questionData.text;
        answers[0].GetComponent<AnswerUI>().SetupAnswer(questionData.posibleAnswers[0]);
        answers[1].GetComponent<AnswerUI>().SetupAnswer(questionData.posibleAnswers[1]);
        answers[2].GetComponent<AnswerUI>().SetupAnswer(questionData.posibleAnswers[2]);
        answers[3].GetComponent<AnswerUI>().SetupAnswer(questionData.posibleAnswers[3]);
    }
}
