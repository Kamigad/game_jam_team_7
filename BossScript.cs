using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TomarDaño(int damage)
    {
        vida -= damage;
        if (vida < 0)
        {
            //aqui va la animacion
        }
    }
}
