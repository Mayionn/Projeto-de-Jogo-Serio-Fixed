using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explanations1 : MonoBehaviour {

    public GameObject[] answersCorrect = { };
    public GameObject[] answersIncorrect = { };

    public GameObject[] explanationCorrect = { };
    public GameObject[] explanationIncorrect = { };

    public GameObject Default;

    public void mouseEnterCorrect1()
    {
        if (answersCorrect[0].activeInHierarchy)
        {
            Default.SetActive(false);
            explanationCorrect[0].SetActive(true);
        } else
        {
            Default.SetActive(true);
            explanationCorrect[0].SetActive(false);
        }
    }
    
    public void mouseExitCorrect1()
    {
        if (answersCorrect[0].activeInHierarchy)
        {
            Default.SetActive(true);
            explanationCorrect[0].SetActive(false);
        }
    }

    public void mouseEnterCorrect2()
    {
        if (answersCorrect[1].activeInHierarchy)
        { 
            Default.SetActive(false);
            explanationCorrect[1].SetActive(true);
        } else
        {
            Default.SetActive(true);
            explanationCorrect[1].SetActive(false);
        }
    }

    public void mouseExitCorrect2()
    {
        if (answersCorrect[1].activeInHierarchy)
        {
            Default.SetActive(true);
            explanationCorrect[1].SetActive(false);
        }
    }
}
