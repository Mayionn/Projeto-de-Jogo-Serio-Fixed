using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabsChangeSprite : MonoBehaviour {

    public Button ambiente;
    public Button alimento;

    public Sprite tabSelected;
    public Sprite tabUnselected;

	// Use this for initialization
	void Start ()
    {
        ambiente.onClick.AddListener(AmbienteOnClick);
        alimento.onClick.AddListener(AlimentoOnClick);
	}
	
	void AmbienteOnClick ()
    {
        alimento.GetComponent<Image>().overrideSprite = tabUnselected;
        ambiente.GetComponent<Image>().overrideSprite = tabSelected;
	}

    void AlimentoOnClick ()
    {
        ambiente.GetComponent<Image>().overrideSprite = tabUnselected;
        alimento.GetComponent<Image>().overrideSprite = tabSelected;
    }
}
