using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction = Vector2.right;
    private bool movingUp = true;

    private void Awake()
    {
        direction = Vector2.right;
    }

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        CheckScreenBounds();

        if (movingUp && transform.position.y >= Screen.height)
        {
            direction.y = -1;
            movingUp = false;
        }

        else if (movingUp && transform.position.y <= 0)
        {
            direction.y = 1;
            movingUp = true;
        }
    }

    void CheckScreenBounds()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < 0 || screenPos.x >= 6.82)
        {
            direction.x = -1;
        }

        if (screenPos.y < 0 || screenPos.y <= -6.82)
        {
            direction.y = 1;
        }
    }
}
