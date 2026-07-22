using UnityEngine;

public class HeandScript : MonoBehaviour
{

    public Transform cameraPlayer;
    public Transform pontoDaMao;
    public float distanciaPegar = 3f;

    private ObjetoAgarravel objetoNaMao;
    private ActivitCardScript objetoNaMaoEUmCard;
    //private paperHolderScripts objOlhadoEUmHolder;
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){

            if(objetoNaMao == null){

                TentarPegar();
            }else{

                tentarSoltar();
            }


        }

        if(objetoNaMao != null){
        
            objetoNaMao.transform.position = pontoDaMao.position;
            objetoNaMao.transform.rotation = pontoDaMao.rotation;
        }
    }

    void TentarPegar(){

        RaycastHit hit;

        if(Physics.Raycast(cameraPlayer.position,cameraPlayer.forward,out hit,distanciaPegar)){

                ObjetoAgarravel obj = hit.collider.GetComponent<ObjetoAgarravel>();
                ActivitCardScript objCard = hit.collider.GetComponent<ActivitCardScript>();

                if(obj != null){

                    objetoNaMao = obj;

                    Rigidbody rb = obj.GetComponent<Rigidbody>();

                    if(rb != null){

                        rb.isKinematic = true;

                    }
                }

                if(obj != null && objCard != null){

                    objetoNaMao = obj;
                    objetoNaMaoEUmCard = objCard;

                    Rigidbody rb = obj.GetComponent<Rigidbody>();

                    if(rb != null){

                        rb.isKinematic = true;


                    }
                }

                
            }
    }

    void Soltar(){

        Rigidbody rb = objetoNaMao.GetComponent<Rigidbody>();

                    if(rb != null){

                        rb.isKinematic = false;

                    }

        objetoNaMao = null;
        objetoNaMaoEUmCard = null;
        
    }

    void tentarSoltar(){

        RaycastHit hit;

        if(Physics.Raycast(cameraPlayer.position,cameraPlayer.forward,out hit,distanciaPegar)){

            paperHolderScripts objHolder = hit.collider.GetComponent<paperHolderScripts>();

            if(objHolder != null && objetoNaMaoEUmCard != null){

               
                objetoNaMao.transform.position = objHolder.transform.position;
                objetoNaMao.transform.rotation = objHolder.transform.rotation;
                objHolder.GetComponent<paperHolderScripts>().papelFoiIncerido = true;
                objetoNaMao = null;
                objetoNaMaoEUmCard = null;
                


                //Debug.Log("pomos o papel no holder");

                return;
            }


        }

        Soltar();

        
        
    }
    
}


