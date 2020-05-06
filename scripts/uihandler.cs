using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uihandler : MonoBehaviour
{
    private void Start()
    {
        Invoke("showad", 2.5f);
    }


    public void StartGame()
    {
        SceneManager.LoadScene(7);
    }

    public void helpbtn()
    {
        SceneManager.LoadScene(6);
    }

    public void QuitBTn()
    {
        Application.Quit();
    }

    public void level1()
    {
        SceneManager.LoadScene(8);
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
    }
    public void level3()
    {
        SceneManager.LoadScene(3);
    }
    public void level4()
    {
        SceneManager.LoadScene(4);
    }
    public void level5()
    {
        SceneManager.LoadScene(5);
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void alllevels()
    {
        SceneManager.LoadScene(7);
    }

    private void showad()
    {
        adsmanager.VideoAd();
    }

}