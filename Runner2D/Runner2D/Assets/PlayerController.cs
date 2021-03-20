using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Fuerza de salto
    public float jumpForce = 20f;

    // Velocidad horizontal del player
    public float speed = 5f;

    // Contador de puntos para incrementar la velocidad
    public int contador;

    // Acceso al componente RidgiBody2d
    private Rigidbody2D myRigidbody2D;

    // Acceso al componente GamenManager
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        // Enlaza con el componente en tiempo de ejecucion
        myRigidbody2D = GetComponent<Rigidbody2D>();

        // Busca un GameObject que tenga un componente de tipo GameManager
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // La velocidad que le aplicamos en la componente vertical es playerJumpForce
            myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, jumpForce);

        }

        // Ahora establecemos un valor para la velocidad horizontal (coordenada x )
        myRigidbody2D.velocity = new Vector2(speed, myRigidbody2D.velocity.y);
        //transform.Translate(new Vector2(speed, myRigidbody2D.velocity.x) * speed * Time.deltaTime);

        switch (contador)
        {
            case 1:
                myRigidbody2D.velocity = new Vector2(speed + 5f, myRigidbody2D.velocity.y);
                break;
            case 2:
                myRigidbody2D.velocity = new Vector2(speed + 10f, myRigidbody2D.velocity.y);
                break;
            case 3:
                myRigidbody2D.velocity = new Vector2(speed + 15f, myRigidbody2D.velocity.y);
                break;
            case 4:
                myRigidbody2D.velocity = new Vector2(speed + 20f, myRigidbody2D.velocity.y);
                break;
            case 5:
                myRigidbody2D.velocity = new Vector2(speed + 25f, myRigidbody2D.velocity.y);
                break;
            case 6:
                myRigidbody2D.velocity = new Vector2(speed + 30f, myRigidbody2D.velocity.y);
                break;
            case 7:
                myRigidbody2D.velocity = new Vector2(speed + 35f, myRigidbody2D.velocity.y);
                break;
            case 8:
                myRigidbody2D.velocity = new Vector2(speed + 40f, myRigidbody2D.velocity.y);
                break;
            case 9:
                myRigidbody2D.velocity = new Vector2(speed + 45f, myRigidbody2D.velocity.y);
                break;
            case 10:
                myRigidbody2D.velocity = new Vector2(speed + 50f, myRigidbody2D.velocity.y);
                break;
            case 11:
                myRigidbody2D.velocity = new Vector2(speed + 60f, myRigidbody2D.velocity.y);
                break;
            case 12:
                myRigidbody2D.velocity = new Vector2(speed + 70f, myRigidbody2D.velocity.y);
                break;
            case 13:
                myRigidbody2D.velocity = new Vector2(speed + 80f, myRigidbody2D.velocity.y);
                break;
            case 14:
                myRigidbody2D.velocity = new Vector2(speed + 90f, myRigidbody2D.velocity.y);
                break;
            case 15:
                myRigidbody2D.velocity = new Vector2(speed + 100f, myRigidbody2D.velocity.y);
                break;
        }

    }

    void OnTriggerEnter2D(Collider2D collision) { 


        if (collision.gameObject.CompareTag("DeathZone"))
        {
            PlayerDead();
        }

        if (collision.CompareTag("Moneda"))
        {
            Destroy(collision.gameObject);
            gameManager.AddScore();
            contador++;

        }
        else if (collision.CompareTag("MonedaBad"))
        {
            PlayerDead();

        }
    }
    void PlayerDead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        contador = 0;
    }

}
