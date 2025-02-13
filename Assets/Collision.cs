using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);

    bool hasPackage;
    SpriteRenderer spriteRenderer;
     void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        
    }
    [SerializeField] float destroyDelay = 0.5f;
    void OnTriggerEnter2D(Collider2D other) 
    {
       if (other.tag == "Package" && hasPackage == false)
       {
        Debug.Log("got it");
        hasPackage = true;
        spriteRenderer.color = hasPackageColor;
        Destroy(other.gameObject, destroyDelay);
       }

       if (other.tag == "Custom" && hasPackage)
       {
        Debug.Log("delivered");
        hasPackage = false;
        spriteRenderer.color = noPackageColor;
       }
    }
}
