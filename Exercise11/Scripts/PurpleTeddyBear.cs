using UnityEngine;
/// <summary>
/// Move the game object
/// </summary>

public class PurpleTeddyBear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get object moving
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(1, 0),
            ForceMode2D.Impulse);
    }
}
