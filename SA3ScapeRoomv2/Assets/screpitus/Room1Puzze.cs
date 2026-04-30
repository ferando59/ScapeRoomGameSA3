using UnityEngine;

public class Room1Puzze : MonoBehaviour
{
    
    private bool puzzDone = false;
    public puzzeCount PuzzeCount;
    public GameObject obj;

    //referencia de fechar portas

    
    
    Animator anim;

    void Start()
    {
        PuzzeCount = obj.GetComponent<puzzeCount>();
        anim = GetComponent<Animator>();
    }

    
   
   
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space)){

            puzzDone = true;

            

        }

        if(puzzDone == true){
            solvePuzz();
            
        }
    }

    void solvePuzz(){

        PuzzeCount.puzzJaFeitas += 1;
        anim.SetInteger("StateDoor", 2);//porta abrindo
        puzzDone = false;

    }

    public void portaAberta(){

        anim.SetInteger("StateDoor", 3);//porta aberta

    }

    public void portaFechada(){

        anim.SetInteger("StateDoor", 1);//porta fechada

    }

    //anim.SetInteger("StateDoor", 1); //porta fechada
    //anim.SetInteger("StateDoor", 2); //porta abrindo
    //anim.SetInteger("StateDoor", 3); //porta aberta
    //anim.SetInteger("StateDoor", 4); //porta fechando

}
