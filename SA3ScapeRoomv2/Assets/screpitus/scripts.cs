using UnityEngine;

public class scripts : MonoBehaviour
{
    public GameObject CloseDoorBox;
    public Animator doorAnimator;
    public Transform cameraTransform;
    public GameObject pontoDeEntrada;

    private Rigidbody rb;


    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Vector3 rotation = cameraTransform.eulerAngles;
        transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);

    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == CloseDoorBox)
        {
            Debug.Log("Objeto correto entrou!");
            doorAnimator.SetInteger("StateDoor", 4);//porta fechando
            Destroy(other.gameObject);
        }

        if (other.CompareTag("clinicDoor"))
        {
            Debug.Log("entramos na clinica");
            transform.position = pontoDeEntrada.transform.position;
        }
    }

    void MovePlayer(){

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        //transform.Translate(xValue,yValue,zValue);

        Vector3 movimento = transform.right * xValue + transform.forward * zValue;
        rb.MovePosition(rb.position + movimento * moveSpeed * Time.deltaTime);

    }
}
