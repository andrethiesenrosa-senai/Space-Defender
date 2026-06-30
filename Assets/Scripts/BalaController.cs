using UnityEngine;

public class BalaController : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody2D.linearVelocity = Vector2.up * 8f;
    }
}
