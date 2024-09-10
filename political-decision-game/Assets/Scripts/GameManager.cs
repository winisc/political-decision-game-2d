using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] boasVindas;
    [SerializeField] private GameObject escolhaDePoliticas;
    [SerializeField] private GameObject hudGame;
    [SerializeField] private GameObject paises;
    [SerializeField] private GameObject[] days;

    // Start is called before the first frame update
    void Start()
    {
        boasVindas[0].SetActive(false);
        boasVindas[1].SetActive(false);
        StartCoroutine(BoasVindas());
        escolhaDePoliticas.SetActive(false);
        hudGame.SetActive(false);
        paises.SetActive(false);
        days[0].SetActive(false);
        days[1].SetActive(false);
        days[2].SetActive(false);
        days[3].SetActive(false);
        days[4].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator BoasVindas()
    {
        boasVindas[0].SetActive(true);
        yield return new WaitForSeconds(3f);
        boasVindas[0].SetActive(false);
        boasVindas[1].SetActive(true);
        yield return new WaitForSeconds(4f);
        boasVindas[1].SetActive(false);
        EscolhaDePolitica();
    }

    private void EscolhaDePolitica()
    {
        escolhaDePoliticas.SetActive(true);
    }
}
