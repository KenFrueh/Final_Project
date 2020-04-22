using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public AudioClip Click;
    public int playerScore = 0;
    public int PlayerLives = 2;
    public GameObject playerPrefab;
    public GameObject Player;


    void Start()
    {
    }
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
    public void StartGame()//The play button in the menu
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
        Debug.Log("Hit Play!");
        AudioSource.PlayClipAtPoint(Click, transform.position);
    }
    public void QuitGame()//Quitting the game
    {
        Application.Quit();
        Debug.Log("You Quit...");
        AudioSource.PlayClipAtPoint(Click, transform.position);
    }
    public void LoadNextScene()//Getting a new scene
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
    public void Respawn()//Respawning the player
    {
        Player = Instantiate(playerPrefab);
    }
    public void Victory()//Victory screen
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }
    public void GameOver()//Game over screen
    {
        SceneManager.LoadScene(sceneBuildIndex: 4);
    }

}
