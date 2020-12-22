using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    private static UI_Manager instance = null;

    // Game Instance Singleton
    public static UI_Manager Instance
    {
        get
        {
            return instance;
        }
    }

    public Situation situation;

    public Text descriptionText;
    public GameObject screen1;
    public GameObject screen2;
    int lastQuestion;
    int currentQuestion;

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        lastQuestion = -1;
        SetupUI();
    }

    void Update()
    {
        
    }

    public void SetupUI()
    {
        descriptionText.text = situation.description;

    }

    public void ChangeStateUI(GameObject toDisable, GameObject toEnable)
    {
        toDisable.SetActive(false);
        toEnable.SetActive(true);
    }

    public void ToScreen1(Situation newSituation)
    {
        situation = newSituation;
        screen1.SetActive(true);
        screen2.SetActive(false);
        SetupUI();
    }
    public void ToScreen2()
    {
        screen2.SetActive(true);
        screen1.SetActive(false);
        OnStartButton();
    }

    public void OnStartButton()
    {
        currentQuestion = Random.Range(0, situation.questions.Length);

        if (currentQuestion == lastQuestion)
        {
            currentQuestion++;
            currentQuestion = currentQuestion % situation.questions.Length;
            //Debug.Log($"Como la pregunta era la misma que la anterior la cambiamos: current: {currentQuestion} last: {lastQuestion}");
        }

        screen2.GetComponent<QuestionUI>().questionData = situation.questions[currentQuestion];
        screen2.GetComponent<QuestionUI>().SetupQuestion();
        lastQuestion = currentQuestion;
    }

}
