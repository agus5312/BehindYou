using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    [SerializeField] GameObject fantasma;
    public GameObject candelabro;
    public GameObject perchero;
    public GameObject cuadro;
    public GameObject mesa;
    public GameObject botas;

    void Start()
    {
        fantasma.transform.position = new Vector2(-2, 4);

        candelabro.SetActive(false);
        mesa.SetActive(false);
        botas.SetActive(false);
    }

    public void CandelabroTp()
    {
        fantasma.transform.position = new Vector2(-2, 4);
        candelabro.SetActive(false);
        mesa.SetActive(false);
        botas.SetActive(false);
        cuadro.SetActive(true);
        perchero.SetActive(true);
    }
    public void PercheroTp()
    {
        fantasma.transform.position = new Vector2(-7.3f, 2);
        candelabro.SetActive(true);
        mesa.SetActive(true);
        botas.SetActive(false);
        cuadro.SetActive(true);
        perchero.SetActive(false);
    }
    public void CuadroTp()
    {
        fantasma.transform.position = new Vector2(-3, -0.3f);
        candelabro.SetActive(true);
        mesa.SetActive(true);
        botas.SetActive(true);
        cuadro.SetActive(false);
        perchero.SetActive(true);
    }
    public void MesaTp()
    {
        fantasma.transform.position = new Vector2(-2.6f,-3.4f);
        candelabro.SetActive(false);
        mesa.SetActive(false);
        botas.SetActive(true);
        cuadro.SetActive(true);
        perchero.SetActive(true);
    }
    public void BotasTp()
    {
        fantasma.transform.position = new Vector2(-5.8f, -4.4f);
        candelabro.SetActive(false);
        mesa.SetActive(true);
        botas.SetActive(false);
        cuadro.SetActive(true);
        perchero.SetActive(false);
    }
}
