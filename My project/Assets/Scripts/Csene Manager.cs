using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CseneManager : MonoBehaviour
{
    [SerializeField] private GameObject _musicBox; 
    public void StartLevel()
    {
        FindObjectOfType<SceneTransition>().ChangeScene("StartVideo");
    }
    public void RestartLevel() => FindObjectOfType<SceneTransition>().ChangeScene("Level");
    
    public void MainMenu()
    {
        //SceneManager.LoadScene("New Menu");
        FindObjectOfType<SceneTransition>().ChangeScene("New Menu");
        
        if (GameObject.FindGameObjectWithTag("DonDestroy") != null)
            GameObject.Destroy(GameObject.FindGameObjectWithTag("DonDestroy"));
            
    }
    
    public void Lose()
    {
        //SceneManager.LoadScene("Lose");
        FindObjectOfType<SceneTransition>().ChangeScene("Lose");
    }
    
    public void Waiting()
    {
        //SceneManager.LoadScene("Waiting");
        FindObjectOfType<SceneTransition>().ChangeScene("Waiting");
    }
    
    public void Authors() => FindObjectOfType<SceneTransition>().ChangeScene("Authors");
    public void Titles() => FindObjectOfType<SceneTransition>().ChangeScene("Titry1");
}
