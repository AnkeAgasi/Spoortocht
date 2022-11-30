using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;


namespace Lambdas{
public class ButtonManager : MonoBehaviour
{

static void Main(string[] args){
  var answers = new List<Answer> {
    new Answer{ Answer = "365", Question = "Hoeveel huizen staan er op de maquette?", Correct = "Correct"},
    new Answer{ Answer = "300", Question = "Hoeveel huizen staan er op de maquette?", Correct = "Incorrect"},
    new Answer{ Answer = "251", Question = "Hoeveel huizen staan er op de maquette?", Correct = "Incorrect"},
    new Answer{ Answer = "370", Question = "Hoeveel huizen staan er op de maquette?", Correct = "Incorrect"}
};


  public void ButtonMoveScene(string level)
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