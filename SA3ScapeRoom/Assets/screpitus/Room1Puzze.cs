using UnityEngine;

public class Room1Puzze : MonoBehaviour
{
    
    private bool puzzDone = false;
    public puzzeCount PuzzeCount;
    public GameObject obj;
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
        puzzDone = false;

    }

    //anim.SetInteger("StateDoor", 1); porta fechada
    //anim.SetInteger("StateDoor", 2); porta abrindo
    //anim.SetInteger("StateDoor", 3); porta aberta
    //anim.SetInteger("StateDoor", 4); porta fechando

}
