using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    
    void Update() {
        //checks what scene its in
        if (Input.GetButton("play")&& SceneManager.GetActiveScene().buildIndex == 0) {//when your on the mainmenu and p is pressed
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);// goes to the next scene
        }
        if (Input.GetButton("play") && SceneManager.GetActiveScene().buildIndex == 2)//when your on the mainmenu and p is pressed
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);// goes to the next scene
        }
    }
    
}
