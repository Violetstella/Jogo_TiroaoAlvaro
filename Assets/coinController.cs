using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinController : MonoBehaviour
{
    public CircleCollider2D Collider2d;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            Destroy(this.gameObject);
        }
    }
}