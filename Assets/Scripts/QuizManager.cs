using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private bool onlyMoveSceneIfAnswersAreCorrect;

    public static List<Answer> AnswersGiven = new List<Answer>();

    [SerializeField] private string questionText;
    [SerializeField] private TextMeshProUGUI questionTextComponent;
 [SerializeField] public bool hasGivenAnswer;

    private void Awake()
    {
        questionTextComponent.text = questionText;
          hasGivenAnswer = false;
    }

     public void hasGivenAnswerTrue(){
        hasGivenAnswer = true;
     }
    public void MoveScene(string level)
    {
        if (!onlyMoveSceneIfAnswersAreCorrect && hasGivenAnswer == true)
        {
            SceneManager.LoadScene(level);
        }

        else
        {
            int correctAnswersGiven = 0;

            if (AnswersGiven.Count != 0)
            {
                foreach(Answer answer in AnswersGiven)
                {
                    if (answer.IsCorrect == true)
                        correctAnswersGiven++;
                }
            }

            if (correctAnswersGiven == 2)
            {
                AnswersGiven.Clear();
                SceneManager.LoadScene(level);
            }
        }
    }
}
