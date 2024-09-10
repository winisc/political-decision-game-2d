using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class informacoesAdd : MonoBehaviour
{
    [SerializeField] private GameObject[] infoApoio;
    [SerializeField] private GameObject[] infoPais;
    // Start is called before the first frame update
    void Start()
    {
        infoApoio[0].SetActive(false);
        infoApoio[1].SetActive(false);
        infoApoio[2].SetActive(false);

        infoPais[0].SetActive(false);
        infoPais[1].SetActive(false);
        infoPais[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void infoApoioPovoEnter()
    {
        infoApoio[0].SetActive(true);
    }
    public void infoApoioPovoExit()
    {
        infoApoio[0].SetActive(false);
    }

    public void infoApoioExercitoEnter()
    {
        infoApoio[1].SetActive(true);
    }
    public void infoApoioExercitoExit()
    {
        infoApoio[1].SetActive(false);
    }

    public void infoApoioPoliticaEnter()
    {
        infoApoio[2].SetActive(true);
    }
    public void infoApoioPoliticaExit()
    {
        infoApoio[2].SetActive(false);
    }

    public void infoPais1Enter()
    {
        infoPais[0].SetActive(true);

    }
    public void infoPais1Exit()
    {
        infoPais[0].SetActive(false);
    }

    public void infoPais2Enter()
    {
        infoPais[1].SetActive(true);

    }
    public void infoPais2Exit()
    {
        infoPais[1].SetActive(false);

    }

    public void infoPais3Enter()
    {
        infoPais[2].SetActive(true);
    }

    public void infoPais3Exit()
    {
        infoPais[2].SetActive(false);
    }
}
