using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject MenuButton;
    public GameObject QuitButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if(Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            QuitButton.SetActive(true);
            MenuButton.SetActive(true);
        }

        else
        {
            Time.timeScale = 1f;
            QuitButton.SetActive(false);
            MenuButton.SetActive(false);
        }
    }
}
