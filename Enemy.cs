using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        vida = 15;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Movimiento>().intDamage();
            Destroy(gameObject);
        }
    }

    public void TomarDaño(int damage)
    {
        vida -= damage;
        if(vida < 0)
        {
            Destroy(gameObject);
        }
    }
}
