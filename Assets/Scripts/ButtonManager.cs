using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;




namespace Lambdas
{
public class ButtonManager : MonoBehaviour
{

public class Questions{
public string Answer;
public string Question; 
public bool Correct; 
public void Answer(string ans, string ques, bool cor){
Answer = ans;
Question = ques; 
Correct = cor;

list<answer> listAnswersQuiz = new List<answer>();
listAnswersQuiz.Add(new answer("365","Hoeveel huizen staan er op de maquette?", "True"));
listAnswersQuiz.Add(new answer("300","Hoeveel huizen staan er op de maquette?", "False"));
listAnswersQuiz.Add(new answer("251","Hoeveel huizen staan er op de maquette?", "False"));
listAnswersQuiz.Add(new answer("270","Hoeveel huizen staan er op de maquette?", "False"));
}
}




void ButtonMoveScene(string level)
    {
        SceneManager.LoadScene(level);
    }
      void TaskOnClick(Button choice)
    { 
      if (choice.gameObject.tag == "Correct")
        {
            Debug.Log("Choice was correct!");
        }
        else
        {
            Debug.Log("Choice was wrong...");
        }
    }


}
}
