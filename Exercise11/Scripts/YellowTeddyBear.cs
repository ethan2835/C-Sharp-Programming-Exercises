using UnityEngine;

public class YellowTeddyBear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // quadruple width and height 
        Vector3 newScale = transform.localScale;

        newScale.x *= 4;
        newScale.y *= 4;

        //change local scale after the changes done above
        transform.localScale = newScale;
    }

}
