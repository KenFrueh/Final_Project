using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReturnToMenu : MonoBehaviour
{//Only purpose is for the gameover/Game over screen

    public AudioClip Click;

    public void MenuButton()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
        AudioSource.PlayClipAtPoint(Click, transform.position);
    }
}
