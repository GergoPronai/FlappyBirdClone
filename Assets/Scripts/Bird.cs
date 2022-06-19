using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{

    [SerializeField] private int points;
    [SerializeField] private float speed = 10000.0f;
    private Rigidbody2D rb;
    
    public Text text;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody not found");
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
            rb.velocity = Vector2.up * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger");
        points++;
        text.text = $"Score: {points}";
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
        SceneManager.LoadScene(0);
    }
}
