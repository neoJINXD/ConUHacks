﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Starting : MonoBehaviour
{
    public Button begin;
    // Start is called before the first frame update
    void Start()
    {
        begin.onClick.AddListener(TaskOnClick);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void TaskOnClick()
        {
            SceneManager.LoadScene(1);
        }
    
}
