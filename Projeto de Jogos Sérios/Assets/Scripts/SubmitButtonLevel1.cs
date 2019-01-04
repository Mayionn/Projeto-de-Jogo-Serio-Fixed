using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitButtonLevel1 : MonoBehaviour
{
    //Botão Submit
    public Button submitButton;

    // Game Objects para os botões
    public Button tryAgain;
    public Button continueGame;

    // Array que contém os gameobjects que quisermos
    public GameObject[] correct = { };
    public GameObject[] incorrect = { };

    // Array do texto que vai conter as respostas corretas e as incorretas
    public GameObject[] text = { };

    private void Start()
    {
        submitButton.onClick.AddListener(submitButtonClicked);
    }


    //Se nenhum objeto estiver ativo na cena, o botão submit está disabled
    private void Update()
    {
        if (!correct[0].activeInHierarchy && !correct [1].activeInHierarchy && !correct[2].activeInHierarchy && !correct[3].activeInHierarchy && !incorrect[0].activeInHierarchy && !incorrect[1].activeInHierarchy && !incorrect[2].activeInHierarchy)
        {
            submitButton.interactable = false;
        }

        if (correct[0].activeInHierarchy || correct[1].activeInHierarchy || correct[2].activeInHierarchy || correct[3].activeInHierarchy || incorrect[0].activeInHierarchy || incorrect[1].activeInHierarchy || incorrect[2].activeInHierarchy)
        {
            submitButton.interactable = true;
        }
    }

    void submitButtonClicked()
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

        if (correct[2].activeInHierarchy)
        {
            text[2].SetActive(true);
        }
        else
        {
            text[2].SetActive(false);
        }

        if (correct[3].activeInHierarchy)
        {
            text[3].SetActive(true);
        }
        else
        {
            text[3].SetActive(false);
        }

        if (incorrect[0].activeInHierarchy)
        {
            text[4].SetActive(true);
        }
        else
        {
            text[4].SetActive(false);
        }

        if (incorrect[1].activeInHierarchy)
        {
            text[5].SetActive(true);
        }
        else
        {
            text[5].SetActive(false);
        }

        if (incorrect[2].activeInHierarchy)
        {
            text[6].SetActive(true);
        }
        else
        {
            text[6].SetActive(false);
        }

        // Se algum texto do array das respostas incorretas estiver visível, um botão a dizer "tentar outra vez" irá aparecer.
        // Caso não, um botão a dizer "continuar" vai aparecer, onde nos vai levar para o próximo nível

        if (text[0].activeInHierarchy && text[1].activeInHierarchy && text[2].activeInHierarchy && text[3].activeInHierarchy)        //Respostas corretas ativas
        {
            if (!text[4].activeInHierarchy && !text[5].activeInHierarchy && !text[6].activeInHierarchy)
            {
                continueGame.interactable = true;
                tryAgain.interactable = false;
            }
        } 

        if (text[4].activeInHierarchy || text[5].activeInHierarchy || text[6].activeInHierarchy)
        {
            continueGame.interactable = false;
            tryAgain.interactable = true;
        }

        if (!text[0].activeInHierarchy || !text[1].activeInHierarchy || !text[2].activeInHierarchy || !text[3].activeInHierarchy)
        {
            continueGame.interactable = false;
            tryAgain.interactable = true;
        }
    }
}

