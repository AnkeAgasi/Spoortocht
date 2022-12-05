using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Answer : MonoBehaviour
{
    private TextMeshProUGUI textComponent;

    public string GetAnswerText { get { return answerText; } }
    [SerializeField] private string answerText;

    public bool IsCorrect { get { return isCorrect; } }
    [SerializeField] private bool isCorrect;

 [SerializeField] public bool hasGivenAnswer;
    public int index;

    Button button;


    private void Awake()
    {

        index = SceneManager.GetActiveScene().buildIndex;
        textComponent = GetComponentInChildren<TextMeshProUGUI>(); // Return the text under the GameObject
    }

    private void Start()
    {
        textComponent.text = answerText;
                hasGivenAnswer = false;
    }

 public void hasGivenAnswerTrue(){
hasGivenAnswer = true;
 }


    public void GiveQuizManagerData()
    {
        if (QuizManager.AnswersGiven.Count > 0)
        {
            if (QuizManager.AnswersGiven[QuizManager.AnswersGiven.Count - 1].index ==
             SceneManager.GetActiveScene().buildIndex)

            {
                QuizManager.AnswersGiven.Remove(QuizManager.AnswersGiven[QuizManager.AnswersGiven.Count - 1]);
            }
        }

        QuizManager.AnswersGiven.Add(this);
    }
}
