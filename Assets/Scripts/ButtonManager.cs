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

class Questions{
string Answer;
string Question; 
bool Correct; 
public Answer(string ans, string ques, bool cor){
Answer = ans;
Question = ques; 
Correct = cor;

}
}
public class answer {
  static int answers = new List<answer> {
    new answer{"driehonderdvijfenzestig","Hoeveel huizen staan er op de maquette?", "Correct"},
    new answer{"driehonderd","Hoeveel huizen staan er op de maquette?","Incorrect"},
    new answer{"tweehonderdeenenvijftig", "Hoeveel huizen staan er op de maquette?", "Incorrect"},
    new answer{"driehonderdzeventig", "Hoeveel huizen staan er op de maquette?", "Incorrect"}
};



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
}