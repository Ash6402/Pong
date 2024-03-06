using UnityEngine;
public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    private Vector2 _direction;
    private Vector2 _velocity;
    
    // Start is called before the first frame update
    private void Start()
    {
        rb.velocity = Vector2.left * speed;
    }

    // Update is called once per frame
    private void Update()
    {
        _velocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            rb.velocity = new Vector2(_velocity.x, _velocity.y * -1);
            return;
        }
        var yContact = other.gameObject.transform.InverseTransformPoint(other.GetContact(0).point).y;
        rb.velocity = new Vector2(_velocity.x * -1,  yContact * speed);
    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0;
    }

    public void Move()
    {
        if(rb.velocity.x == 0)
            rb.velocity = Vector2.left * speed;
    }
}
