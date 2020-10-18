﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelMenu;

    public GameObject optionScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SartGame(){
        Time.timeScale=1;
        SceneManager.LoadScene(levelMenu);     
    }

    public void OpenOptions(){
        optionScreen.SetActive(true);
    }

    public void CloseOptions(){
        optionScreen.SetActive(false);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
