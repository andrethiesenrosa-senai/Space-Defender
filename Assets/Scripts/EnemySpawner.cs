using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Start()
    {
        Invoke("MensagemInicio", 1f);
        InvokeRepeating("SpawnInimigo", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnInimigo()
    {
        float x = Random.Range(-7f, 7f);
        Vector3 posicao = new Vector3(x, 6f, 0);
        Instantiate(enemyPrefab, posicao, Quaternion.identity);
    }

    void MensagemInicio()
    {
        Debug.Log("Começou a onde de inimigos");
    }
}
