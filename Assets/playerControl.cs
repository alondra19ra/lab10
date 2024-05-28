using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    transform posicion;
    public int velocidad;
    public int xDireccion = 1;
    public int yDireccion = 1;
    
    void Awake()
    {
        posicion = GetComponent<Transformer>();
        cambio = GetComponent<SpriteRenderer>();
    }


    void Start()
    {
        
    }

    void Update()
    {
        transform.posicion = new Vector2(posicion.posicion.x  + velocidad * xDireccion  *Time.deltaTime, posicion.posicion.y);


        if (posicion.posicion.x >= 6.82)
        {
            if (cambio.flipX == true)
            {
                cambio.flipX = false;
                cambio.flipY = false;
            }
            else 
            {
                cambio.flipX = true;
                cambio.flipY = true;
            }

            xDireccion = -1;
        }
        if (posicion.posicion.x <= -6.82)
        {
           if (cambio.flipX == true)
           {
               cambio.flipX = false;
               cambio.flipY = false;
           }

           else 
           {
               cambio.flipX = true;
               cambio.flipY = true;
           }

           xDireccion = 1;
        }

        transform.posicion = new Vector2(posicion.posicion.x, posicion.position.y+velocidad*ydireccion*Time.deltaTime);

        if (posicion.posicion.y >= 4.56)
        {
           if (cambio.flipX == true)
           {
               cambio.flipX = false;
               cambio.flipY = false;
           }

           else 
           {
               cambio.flipX = true;
               cambio.flipY = true;
           }

           yDireccion = -1;
           
        }

        if (posicion.posicion.y <= -4.56)
        {
            if (cambio.flipX == true)
            {
                cambio.flipX = false;
                cambio.flipY = false;
            }
            else
            {
                cambio.flipX = true;
                cambio.flipY = true;
            }

            yDireccion = 1;
        }
    }
}
