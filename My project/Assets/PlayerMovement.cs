using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    public bool isMoving = false; // 用于判断角色是否正在移动
    public AudioClip footstepSound; // 脚步声音效
    //AudioSource footstepSource;
   /* private float footstepDelay = 0.5f; // 控制脚步声的播放间隔
    private float footstepTimer = 0f;*/
    [SerializeField]
    SoundManager soundManager;
    public string scenePassword;//出生点设置
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Debug.Log("get!");
        }
        else
        {
            if (instance != this)
            {   Destroy(gameObject);
            Debug.Log("die");
            }
        }
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // footstepSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        //Move();
        //Jump();
        MoveandJump();
    }

    private void MoveandJump()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2();
        movement.x = horizontalInput * moveSpeed;
        // Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
 /*       Debug.Log(movement);*/
        if (Input.GetKey(KeyCode.W))
        {
            movement.y = jumpForce;
            // rb.velocity= new Vector2(rb.velocity.x, jumpForce);
        }
        if (Mathf.Abs(horizontalInput) > 0.1f && movement.y < 0.1f && movement.y > -0.1f)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
       
     /*  if (isMoving)
        {
            soundManager.PlayFootstepSound();
        }
        else
        {
            soundManager.StopFootstepSound();
        }*/
        //Debug.Log(movement);
        rb.velocity = movement;
    }

    private void Jump()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    public bool GETifplayerMoving()
    {
        return isMoving;
    }
}
