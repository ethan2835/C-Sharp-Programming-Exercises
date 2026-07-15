using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
    /// <summary>
    /// Start is called once before the first execution of Update after the 
    /// MonoBehaviour is created
    /// </summary>
    void Start()
    {
        // get the teddy bear moving
        GetComponent<Rigidbody2D>().AddForce(new Vector2(3, 0), ForceMode2D.Impulse);
    }
}
