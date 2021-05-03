using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Interacciones : MonoBehaviour
{
    public GameObject todasLasMonedas;
    public GameObject victoriaUI;
    public Text textoMonedas;

    int maxMonedas;
    int monedas;

    void Start()
    {
        maxMonedas = todasLasMonedas.transform.childCount;
        textoMonedas.text = "Monedas: 0/" + maxMonedas;
    }
    
    private void OnTriggerEnter2D(Collider2D otros) {
        if(otros.gameObject.CompareTag("Moneda"))
        {
            monedas++;
            textoMonedas.text = "Monedas: " + monedas + "/" + maxMonedas;
            Destroy(otros.gameObject);

            if(monedas == maxMonedas)
            {
                victoriaUI.SetActive(!victoriaUI.activeSelf);
            }
        }
        
        if(otros.gameObject.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}