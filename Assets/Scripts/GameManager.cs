using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public AudioClip Click;
    public int playerScore = 0;
    public int PlayerLives = 3;

    void Awake()
    {
        if (instance == null)
        {
            instance = this; //Shows THIS of class in int variable
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(this.gameObject); //Destroy Game manager attached to component
            Debug.LogError("Error: Tried to make second Game Manager");
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
        Debug.Log("Hit Play!");
        AudioSource.PlayClipAtPoint(Click, transform.position);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("You Quit...");
        AudioSource.PlayClipAtPoint(Click, transform.position);
    }
}
