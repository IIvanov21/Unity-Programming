using UnityEngine;

[RequireComponent(typeof(InputReader))]
public class PlayerController : MonoBehaviour
{
   
    //[Tooltip("Player speed variable")]

    [SerializeField]
    private float sensitivity = 2f;        // Mouse sensitivity

    [SerializeField,Range(-60f, 60f)]
    private float minY = -60f;             // Min vertical angle
    [SerializeField,Range(-60f, 60f)]
    private float maxY = 60f;              // Max vertical angle
    
    [field:SerializeField]
    public float playerSpeed {  get;  private set; }
    Vector3 movement;
    //DataTypes data;

    [SerializeField]
    private InputReader inputReader;

    private float verticalRotation = 0f;  // Current vertical rotation

    private void Awake()
    {
        inputReader.AttackEvent += Attack;
    }

    private void Start()
    {
        //data = new DataTypes();
        inputReader = GetComponent<InputReader>();
        playerSpeed = 5f;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnDestroy()
    {
        inputReader.AttackEvent -= Attack;
    }

    void Update()
    {
        CameraWork();

        Move();


        
    }

    void CameraWork()
    {
        float mouseX = inputReader.lookValue.x * sensitivity; 
        
        transform.Rotate(mouseX * Vector3.up);

        float mouseY = inputReader.lookValue.y * sensitivity;

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, minY, maxY);

        Camera.main.transform.localEulerAngles = new Vector3(verticalRotation, 0f, 0f);
    }

    public void Attack()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f));

        if(Physics.Raycast(ray, out RaycastHit hit,5f))
        {
            var dummy=hit.collider.GetComponent<TargetDummy>();
            if(dummy != null)
            {
                dummy.TakeDamage();
                Debug.Log("Target hit!");
            }
        }
    }

    void Move()
    {
        
        movement.x = inputReader.movementValue.x;
        movement.z= inputReader.movementValue.y;
        movement.y = 0;
        transform.Translate(movement * Time.deltaTime * playerSpeed);
    }

    
}
