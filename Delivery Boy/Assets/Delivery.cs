using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 255);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 255);

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Eita porra!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package pick up!");
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }

        if(collision.tag == "Costumer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
