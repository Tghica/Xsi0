using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    private Color start;
    private Color finish;
    private float timer = 0;
    public float time;
    void Start()
    {
        start = GetComponent<SpriteRenderer>().color;
        finish = GetComponent<SpriteRenderer>().color;
        finish.a = 0;
    }
    void Update()
    {
        timer += Time.deltaTime;
        float t = timer / time;
        GetComponent<SpriteRenderer>().color = Tween(t);
    }
    private Color Tween(float t)
    {
        return (1 - t) * start + t * finish;
    }
}
