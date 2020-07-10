using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseTrack : MonoBehaviour
{
    
    private Rigidbody2D playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        playerRigidbody.transform.position = new Vector2(newPosition.x, newPosition.y);
        
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
