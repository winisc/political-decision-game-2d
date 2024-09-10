using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escolhas : MonoBehaviour
{
    [SerializeField] private GameObject escolhaDePoliticas;
    [SerializeField] private GameObject hudGame;
    [SerializeField] private GameObject paises;
    [SerializeField] private GameObject[] dia;

    [SerializeField] private GameObject[] escolhasPrincipais;

    [SerializeField] private GameObject buttonNuclear;
    [SerializeField] private GameObject avancar;
    [SerializeField] private GameObject fade;

    [SerializeField] private float valueAtualPovo;
    [SerializeField] private float valueAtualExercito;
    [SerializeField] private float valueAtualPolitica;

    [SerializeField] private GameObject[] confirmPais;
    [SerializeField] private Button[] buttonsPaises;

    [SerializeField] private bool escolheuDialogo;
    [SerializeField] private bool escolheuForcaMilitar;

    private Calculos calculos;
    // Start is called before the first frame update
    void Start()
    {
        escolheuForcaMilitar = false;
        escolheuDialogo = false;

        calculos = FindAnyObjectByType<Calculos>();

        dia[0].SetActive(false);
        escolhasPrincipais[0].SetActive(false);
        escolhasPrincipais[1].SetActive(false);
        escolhasPrincipais[2].SetActive(false);
        escolhasPrincipais[3].SetActive(false);
        buttonNuclear.SetActive(false);
        fade.SetActive(false);

        valueAtualPovo = 0;
        valueAtualExercito = 0;
        valueAtualPolitica = 0;

        confirmPais[0].SetActive(false);
        confirmPais[1].SetActive(false);
        confirmPais[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscolheuTirania()
    {
        calculos.valuePovo = .3f;
        valueAtualPovo = calculos.valuePovo;
        calculos.valueExercito = .7f;
        valueAtualExercito = calculos.valueExercito;
        calculos.valuePolitica = .4f;
        valueAtualPolitica = calculos.valuePolitica;

        escolhaDePoliticas.SetActive(false);
        hudGame.SetActive(true);
        StartCoroutine(Dia1());
    }

    public void EscolheuDemocracia()
    {
        calculos.valuePovo = .7f;
        valueAtualPovo = calculos.valuePovo;
        calculos.valueExercito = .4f;
        valueAtualExercito = calculos.valueExercito;
        calculos.valuePolitica = .4f;
        valueAtualPolitica = calculos.valuePolitica;

        escolhaDePoliticas.SetActive(false);
        hudGame.SetActive(true);
        StartCoroutine(Dia1());
    }

    public void EscolheuMonarquia()
    {
        calculos.valuePovo = .4f;
        valueAtualPovo = calculos.valuePovo;
        calculos.valueExercito = .4f;
        valueAtualExercito = calculos.valueExercito;
        calculos.valuePolitica = .7f;
        valueAtualPolitica = calculos.valuePolitica;

        escolhaDePoliticas.SetActive(false);
        hudGame.SetActive(true);
        StartCoroutine(Dia1());
    }

    IEnumerator Dia1()
    {
        yield return new WaitForSeconds(1);
        dia[0].SetActive(true);
        yield return new WaitForSeconds(3f);
        dia[0].SetActive(false);
        yield return new WaitForSeconds(1);
        EscolhasPrincipais();
    }
    IEnumerator Dia2()
    {
        yield return new WaitForSeconds(2);
        dia[1].SetActive(true);
        yield return new WaitForSeconds(3f);
        dia[1].SetActive(false);
        yield return new WaitForSeconds(1);
        if(escolheuDialogo)
        {
            escolhasPrincipais[2].SetActive(true);
        }
        else if(escolheuForcaMilitar)
        {
            escolhasPrincipais[3].SetActive(true);
        }

    }
    public void Avancar()
    {
        avancar.SetActive(false);
        paises.SetActive(true);
    }
    private void EscolhasPrincipais()
    {
        escolhasPrincipais[0].SetActive(true);
    }

    public void Escolha1_1()
    {
        escolhasPrincipais[0].SetActive(false);
        escolhasPrincipais[1].SetActive(true);

        calculos.valuePovo = valueAtualPovo + .1f ;
        valueAtualPovo = calculos.valuePovo;
        calculos.valueExercito = valueAtualExercito - .1f;
        valueAtualExercito = calculos.valueExercito;
        calculos.valuePolitica = valueAtualPolitica + 0f;
        valueAtualPolitica = calculos.valuePolitica;

        escolheuDialogo = true;
    }

    public void Escolha1_2()
    {
        escolhasPrincipais[0].SetActive(false);
        escolhasPrincipais[1].SetActive(true);

        calculos.valuePovo = valueAtualPovo - .1f ;
        valueAtualPovo = calculos.valuePovo;
        calculos.valueExercito = valueAtualExercito + .1f;
        valueAtualExercito = calculos.valueExercito;
        calculos.valuePolitica = valueAtualPolitica + 0f;
        valueAtualPolitica = calculos.valuePolitica;

        escolheuForcaMilitar = true;
    }

    public void Pais1()
    {
        confirmPais[0].SetActive(true);
        buttonsPaises[0].interactable = false;
        buttonsPaises[1].interactable = false;
        buttonsPaises[2].interactable = false;
    }

    public void Pais2()
    {
        confirmPais[1].SetActive(true);
        buttonsPaises[0].interactable = false;
        buttonsPaises[1].interactable = false;
        buttonsPaises[2].interactable = false;
    }

    public void Pais3()
    {
        confirmPais[2].SetActive(true);
        buttonsPaises[0].interactable = false;
        buttonsPaises[1].interactable = false;
        buttonsPaises[2].interactable = false;
    }

    public void ConfirmPais1()
    {
        calculos.valuePovo = valueAtualPovo + 0 ;
        valueAtualPovo = calculos.valuePovo;
        calculos.valueExercito = valueAtualExercito + .1f;
        valueAtualExercito = calculos.valueExercito;
        calculos.valuePolitica = valueAtualPolitica + .1f;
        valueAtualPolitica = calculos.valuePolitica;

        paises.SetActive(false);
        StartCoroutine(Fade());
        StartCoroutine(Dia2());

    }
    public void CancelPais1()
    {
        confirmPais[0].SetActive(false);
        buttonsPaises[0].interactable = true;
        buttonsPaises[1].interactable = true;
        buttonsPaises[2].interactable = true;
    }

    public void ConfirmPais2()
    {
        calculos.valuePovo = valueAtualPovo + .1f ;
        valueAtualPovo = calculos.valuePovo;
        calculos.valueExercito = valueAtualExercito - .1f;
        valueAtualExercito = calculos.valueExercito;
        calculos.valuePolitica = valueAtualPolitica + 0f;
        valueAtualPolitica = calculos.valuePolitica;

        paises.SetActive(false);
        StartCoroutine(Fade());
        StartCoroutine(Dia2());
    }

    public void CancelPais2()
    {
        confirmPais[1].SetActive(false);
        buttonsPaises[0].interactable = true;
        buttonsPaises[1].interactable = true;
        buttonsPaises[2].interactable = true;
    }

    public void ConfirmPais3()
    {
        calculos.valuePovo = valueAtualPovo - .1f ;
        valueAtualPovo = calculos.valuePovo;
        calculos.valueExercito = valueAtualExercito + 0f;
        valueAtualExercito = calculos.valueExercito;
        calculos.valuePolitica = valueAtualPolitica - .1f;
        valueAtualPolitica = calculos.valuePolitica;

        paises.SetActive(false);
        StartCoroutine(Fade());
        StartCoroutine(Dia2());
    }

    public void CancelPais3()
    {
        confirmPais[2].SetActive(false);
        buttonsPaises[0].interactable = true;
        buttonsPaises[1].interactable = true;
        buttonsPaises[2].interactable = true;
    }

    IEnumerator Fade()
    {
        fade.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        fade.SetActive(false);
    }
}
