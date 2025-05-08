using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HOME : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void btnplay()
    {
        SceneManager.LoadScene("game");
    }
    public void btnset()
    {
        SceneManager.LoadScene("setting");
    }
}
