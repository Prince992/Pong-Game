using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.name == "Player1")
        {
            float verticalInput1 = Input.GetAxis("Vertical");
            rb.velocity = new Vector2(0f, speed * verticalInput1);
        }
        else
        {
            float verticalInput2 = Input.GetAxis("Vertical2");
            rb.velocity = new Vector2(0f, speed * verticalInput2 );
        }
    }
}
