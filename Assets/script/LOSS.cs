using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class LOSS : MonoBehaviour
{
    public Text l;
    int score = 0;
    void Start()
    {
        score = PlayerPrefs.GetInt("score", 0);
        l.text = "score "+score;
    }

    void Update()
    {
        
    }
    public void btncontinue()
    {
        SceneManager.LoadScene("game");
    }
    public void btnhome()
    {
        SceneManager.LoadScene("home");
    }
   

}
