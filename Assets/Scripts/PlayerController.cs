using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float velocidade = 5.5f;
    public GameObject balaPrefab;
    public Transform pontoDeDisparo;
    public float proximoDisparo = 0f;
    public float powerUpTime = 0f;
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
        if(Time.time > proximoDisparo)
        {
            Debug.Log("Time.time: " + Time.time);
            Instantiate(balaPrefab, pontoDeDisparo.position, Quaternion.identity);
            proximoDisparo = Time.time + 0.3f;
        }
        
    }



}


