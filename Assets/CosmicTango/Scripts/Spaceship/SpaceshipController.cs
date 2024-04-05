using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class SpaceshipController : MonoBehaviour
{
    #region Variables
    [Header("\tSpaceship speed")]
    [Range(0, 20f)]
    [SerializeField] private float shipSpeed = 15f; // rocket speed OY)
    [Range(0, 5f)]
    [SerializeField] private float rotationSpeed = 2f; // rocket spped OX - for rotation position)

    [Space]
    [Header("\tSpaceship parts")]
    [SerializeField] private List<GameObject> partsOfShip;

    [Space]
    [Header("\tSpaceship's list of fuel particles")]
    [SerializeField] private List<GameObject> particles;

    // buttons
    private Button leftButton;
    private Button rightButton;


    // private 
    private Animation anim;
    private AudioSource audioSource;
    private Rigidbody2D rigidbody;

    private float direction = 0f;
    private float moveX;

    // inputs
    InputSystem controls;


    // Recognition
    private AudioClip clip;
    private byte[] bytes;
    private bool recording;


    #endregion 
    // Start is called before the first frame update

    private void Awake()
    {
        controls = new InputSystem();
        controls.Enable();

        controls.Ship.Movement.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };


    }
    void Start()
    {
        anim = GetComponent<Animation>();
        audioSource = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody2D>();

    }

   
    // Update is called once per frame
    void Update()
    {
        moveX = direction * shipSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rigidbody.velocity;
        velocity.x = moveX;

        rigidbody.velocity = velocity;
    }

    private void LeftButton()
    {

    }
    private void LoadSkinShip()
    {
        // set active all ship's parts
        foreach (GameObject part in partsOfShip)
        {
            if (part.name != "Base main")
            {
                // Get value if rocket part is added.
                bool partAdded = PlayerPrefs.GetInt("PartAdded - " + part.name, 0) == 1 ? true : false;
                // Set rocket part gameobject state to active or disabled according to partAdded value.
                part.SetActive(partAdded);
            }
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
