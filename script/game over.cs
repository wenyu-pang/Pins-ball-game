using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject gaemOverPanel;


    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")==null)
        {
            gaemOverPanel.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
