using UnityEngine;

public class scripts : MonoBehaviour
{
    public GameObject CloseDoorBox;
    public Animator doorAnimator;


    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == CloseDoorBox)
        {
            Debug.Log("Objeto correto entrou!");
            doorAnimator.SetInteger("StateDoor", 4);//porta fechando
            Destroy(other.gameObject);
        }
    }

    void MovePlayer(){

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,yValue,zValue);

    }
}
