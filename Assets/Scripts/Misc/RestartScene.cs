using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartScene : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Choose Character");
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
            print("quit");
        }

    }
}
