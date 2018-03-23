using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {


    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        //For testing purposes
        if (Input.GetKeyDown(KeyCode.Q) && GameObject.FindGameObjectWithTag("RedPlayer"))
        {
            GameObject player = GameObject.FindGameObjectWithTag("RedPlayer");
            player.transform.position = new Vector3(111f, -8f, 1f);

        }
        if (Input.GetKeyDown(KeyCode.E) && GameObject.FindGameObjectWithTag("RedPlayer"))
        {
            GameObject player = GameObject.FindGameObjectWithTag("RedPlayer");
            player.transform.position = new Vector3(-111f, -8f, 1f);

        }
        if (Input.GetKeyDown(KeyCode.Q) && GameObject.FindGameObjectWithTag("BluePlayer"))
        {
            GameObject player = GameObject.FindGameObjectWithTag("BluePlayer");
            player.transform.position = new Vector3(111f, -8f, 1f);

        }
        if (Input.GetKeyDown(KeyCode.E) && GameObject.FindGameObjectWithTag("BluePlayer"))
        {
            GameObject player = GameObject.FindGameObjectWithTag("BluePlayer");
            player.transform.position = new Vector3(-111f, -8f, 1f);

        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitMenu()
    {
        Application.Quit();

    }
}
