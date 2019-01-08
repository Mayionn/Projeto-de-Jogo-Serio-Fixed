using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explanations2 : MonoBehaviour
{

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

    public void mouseEnterCorrect3()                            //Bunny
    {
        if (answersCorrect[2].activeInHierarchy)
        {
            Default.SetActive(false);
            explanationCorrect[2].SetActive(true);
        }
    }

    public void mouseExitCorrect3()
    {
        if (answersCorrect[2].activeInHierarchy)
        {
            Default.SetActive(true);
            explanationCorrect[2].SetActive(false);
        }
    }



    public void mouseEnterIncorrect1()
    {
        if (answersIncorrect[0].activeInHierarchy)
        {
            Default.SetActive(false);
            explanationIncorrect[0].SetActive(true);
        }
    }

    public void mouseExitIncorrect1()
    {
        if (answersIncorrect[0].activeInHierarchy)
        {
            Default.SetActive(true);
            explanationIncorrect[0].SetActive(false);
        }
    }

    public void mouseEnterIncorrect2()
    {
        if (answersIncorrect[1].activeInHierarchy)
        {
            Default.SetActive(false);
            explanationIncorrect[1].SetActive(true);
        }
    }

    public void mouseExitIncorrect2()
    {
        if (answersIncorrect[1].activeInHierarchy)
        {
            Default.SetActive(true);
            explanationIncorrect[1].SetActive(false);
        }
    }

    public void mouseEnterIncorrect3()
    {
        if (answersIncorrect[2].activeInHierarchy)
        {
            Default.SetActive(false);
            explanationIncorrect[2].SetActive(true);
        }
    }

    public void mouseExitIncorrect3()
    {
        if (answersIncorrect[2].activeInHierarchy)
        {
            Default.SetActive(true);
            explanationIncorrect[2].SetActive(false);
        }
    }

    public void mouseEnterIncorrect4()
    {
        if (answersIncorrect[3].activeInHierarchy)
        {
            Default.SetActive(false);
            explanationIncorrect[3].SetActive(true);
        }
    }

    public void mouseExitIncorrect4()
    {
        if (answersIncorrect[3].activeInHierarchy)
        {
            Default.SetActive(true);
            explanationIncorrect[3].SetActive(false);
        }
    }

    public void mouseEnterIncorrect5()
    {
        if (answersIncorrect[4].activeInHierarchy)
        {
            Default.SetActive(false);
            explanationIncorrect[4].SetActive(true);
        }
    }

    public void mouseExitIncorrect5()
    {
        if (answersIncorrect[4].activeInHierarchy)
        {
            Default.SetActive(true);
            explanationIncorrect[4].SetActive(false);
        }
    }

    public void mouseEnterIncorrect6()                                  //cacti
    {
        if (answersIncorrect[5].activeInHierarchy)
        {
            Default.SetActive(false);
            explanationIncorrect[5].SetActive(true);
        }
    }

    public void mouseExitIncorrect6()
    {
        if (answersIncorrect[5].activeInHierarchy)
        {
            Default.SetActive(true);
            explanationIncorrect[5].SetActive(false);
        }
    }
}
