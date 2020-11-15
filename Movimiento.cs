using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public int vida, escudo;
    public float velocidad = 2f;
    public float Maxv = 51f;
    private Rigidbody2D rb2d;
    private Transform jugador;
    public float bordeIzquierdo, bordeDerecho;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        jugador = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce(Vector2.right * velocidad * h);

        if (rb2d.velocity.x > Maxv)
        {
            rb2d.velocity = new Vector2(Maxv, rb2d.velocity.y);
        } 
    }

    public void intDamage()
    {
        if (escudo == 0)
        {
            vida -= 1;
        }
        else if (escudo > 0 && vida > 0)
        {
            escudo -= 1;
        }
        else if (vida == 0)
        {
            //aqui va donde seria el fin del juego
        }
    }
}
