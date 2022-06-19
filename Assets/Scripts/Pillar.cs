using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Pillar : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(-speed * Time.deltaTime, 0));

        if (IsOutOfScene())
        {
            float rightSide = 9.3f;
            float height = Random.Range(3.2f, -3.8f);
            this.transform.position = new Vector2(rightSide, height);
        }
    }

    bool IsOutOfScene()
    {
        float leftSide = -9.3f;

        return this.transform.position.x < leftSide;
    }
}
