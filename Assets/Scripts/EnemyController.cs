using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float velocidade = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.down * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bala"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
