using UnityEngine;

public class Personaje : MonoBehaviour
{
    float movimiento = 0f;
    float velocidadMovimiento = 8f;
    float fuerzaDeSalto = 7f;

    public Rigidbody2D rigidbody2D; 

    void Update()
    {
        movimiento = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movimiento, 0, 0) * velocidadMovimiento * Time.deltaTime;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody2D.velocity.y) < 0.001f)
        {
            rigidbody2D.AddForce(new Vector2(0, fuerzaDeSalto), ForceMode2D.Impulse);
        }
    }
}
