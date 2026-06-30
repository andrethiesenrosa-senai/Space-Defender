using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float velocidade = 5.5f;
    public GameObject balaPrefab;
    public Transform pontoDeDisparo;
    void Start()
    {
        
    }
    void Update()
    {
        MoverNave();
        VerificarDisparo();
    }

    private void MoverNave()
    {
        float direcao = Input.GetAxis("Horizontal");
        Debug.Log(direcao);

        transform.Translate(Vector2.right * direcao * velocidade * Time.deltaTime);

    }

    private void VerificarDisparo()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Atirar();
        }
        if(Input.GetMouseButtonDown(0))
        {
            Atirar();
        }
    }

    private void Atirar()
    {
        Debug.Log("Atirei");
        Instantiate(balaPrefab, pontoDeDisparo.position, Quaternion.identity);
        
    }



}


