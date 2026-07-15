using UnityEngine;

public class GreenTeddyBear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // triple height and 1.5x width
        Vector3 newScale = transform.localScale;

        newScale.y *= 3;
        newScale.x *= 1.5f;

        //change local scale after the change done above
        transform.localScale = newScale;

    }

   
}
