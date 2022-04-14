using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
 public void RestartGame(){
    SceneManager.LoadScene("Point Collector");
 }
 public void Home(){
    SceneManager.LoadScene("Main menue");
 }
}
