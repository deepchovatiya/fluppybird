using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SETTING : MonoBehaviour
{
    public Button btnon, btnoff;
    public Slider slider;
    void Start()
    {
        slider=GetComponent<Slider>();
    }
    void Update()
    {
        
    }
    public void btnch(int n)
    {
        PlayerPrefs.SetInt("n",n);
    }
    public void changebird(int bi)
    {
        PlayerPrefs.SetInt("bi",bi);
    }
    public void btnplay()
    {
        SceneManager.LoadScene("game");
    }
    public void btnsound(int so)
    {
        PlayerPrefs.SetInt("so",so);
        print(so);
        if(so==0)
        {
            btnon.interactable = false;
            btnoff.interactable = true;
        }
        else if(so==1)
        {
            btnoff.interactable = false;
            btnon.interactable = true;
        }
    }
    public void sliderbtn(float sli)
    {
        PlayerPrefs.SetFloat("sli",sli);
        slider.value = sli;
        
    }
}
