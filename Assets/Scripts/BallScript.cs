using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 6f;
    Vector3 Original_Pos;
    public Text Player1_Score, Player2_Score;
    public int p1=0, p2=0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Original_Pos = transform.position;
        Reset_Ball();
        p1 = 0; p2= 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reset_Ball()
    {
        transform.position = Original_Pos;
        float X = Random.Range(-1f, 1f);
        float Y = Random.Range(-1f, 1f);

        Vector2 Direction = new Vector2(speed*X, speed*Y).normalized;
        rb.velocity = speed*Direction;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.name == "RightWall" || other.collider.name == "LeftWall")
        {
            if (other.collider.name == "LeftWall")
            {
                p1++;
                Player1_Score.text = p1.ToString();
            }
            if(other.collider.name == "RightWall")
            {
                p2++;
                Player2_Score.text = p2.ToString();
            }
            Reset_Ball();
        }
    }
}
