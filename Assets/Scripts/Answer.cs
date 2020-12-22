using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Answer", menuName = "Answer")]
public class Answer : ScriptableObject
{
    public string text;
    public Situation situation;
    public bool isCorrect;
    public bool isEnd;
    public Situation nextSituation;
}

