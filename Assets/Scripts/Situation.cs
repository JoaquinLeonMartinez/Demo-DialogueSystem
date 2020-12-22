using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Situation", menuName = "Situation")]
public class Situation : ScriptableObject
{
    public string description;
    public int id;
    public Question[] questions;
}
