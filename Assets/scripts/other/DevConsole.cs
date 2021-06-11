using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DevConsole : MonoBehaviour
{




    public GameObject devconsole;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Home))
        {
            ToggleConsole();
        }
    }

    public void ToggleConsole()
    {
        if (!devconsole.activeSelf)
        {
            devconsole.SetActive(true);
        }
        else if (devconsole.activeSelf)
        {
            devconsole.SetActive(false);
        }
    }

    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}
