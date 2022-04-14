using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenueController : MonoBehaviour
{
   public void PlayGame(){

       int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
       GameManager.instance.charIndex = selectedCharacter ;
       SceneManager.LoadScene("Point collector");
     
   }
} //class












