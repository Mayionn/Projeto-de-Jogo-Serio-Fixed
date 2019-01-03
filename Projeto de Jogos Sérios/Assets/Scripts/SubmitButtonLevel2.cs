using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitButtonLevel2 : MonoBehaviour
{

    public GameObject submitPanel;

    // Game Objects para os botões
    public GameObject tryAgain;
    public GameObject continueGame;

    // Array que contém os gameobjects que quisermos
    public GameObject[] correct = { };
    public GameObject[] incorrect = { };

    // Array do texto que vai conter as respostas corretas e as incorretas
    public GameObject[] text = { };

    void Update()
    {

        // Se o primeiro objeto do array estiver ativo, então o texto também vai estar ativo
        if (correct[0].activeInHierarchy)
        {
            text[0].SetActive(true);
        }
        else
        {
            text[0].SetActive(false);
        }

        if (correct[1].activeInHierarchy)
        {
            text[1].SetActive(true);
        }
        else
        {
            text[1].SetActive(false);
        }

        if (incorrect[0].activeInHierarchy)
        {
            text[2].SetActive(true);
        }
        else
        {
            text[2].SetActive(false);
        }

        if (incorrect[1].activeInHierarchy)
        {
            text[3].SetActive(true);
        }
        else
        {
            text[3].SetActive(false);
        }

        if (incorrect[2].activeInHierarchy)
        {
            text[4].SetActive(true);
        }
        else
        {
            text[4].SetActive(false);
        }

        if (incorrect[3].activeInHierarchy)
        {
            text[5].SetActive(true);
        }
        else
        {
            text[5].SetActive(false);
        }

        if (incorrect[4].activeInHierarchy)
        {
            text[6].SetActive(true);
        }
        else
        {
            text[6].SetActive(false);
        }

        // Se algum texto do array das respostas incorretas estiver visível, um botão a dizer "tentar outra vez" irá aparecer.
        // Caso não, um botão a dizer "continuar" vai aparecer, onde nos vai levar para o próximo nível
        if (text[2].activeInHierarchy || text[3].activeInHierarchy || text[4].activeInHierarchy || text[5].activeInHierarchy || text[6].activeInHierarchy)                                          // Texto "Tentar outra vez"
        {
            tryAgain.SetActive(true);
            continueGame.SetActive(false);
        }

        if (text[0].activeInHierarchy && text[1].activeInHierarchy)             // Texto "Continuar"
        {
            continueGame.SetActive(true);
            tryAgain.SetActive(false);
        }
        else
        {
            tryAgain.SetActive(true);
            continueGame.SetActive(false);
        }
    }
}


