using UnityEngine;

public class HeandScript : MonoBehaviour
{

    public Transform cameraPlayer;
    public Transform pontoDaMao;
    public float distanciaPegar = 3f;

    private ObjetoAgarravel objetoNaMao;
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){

            if(objetoNaMao == null){

                TentarPegar();
            }else{

                Soltar();
            }
        }

        if(objetoNaMao != null){
        
            objetoNaMao.transform.position = pontoDaMao.position;
        }
    }

    void TentarPegar(){

        RaycastHit hit;

        if(Physics.Raycast(cameraPlayer.position,cameraPlayer.forward,out hit,distanciaPegar)){

                ObjetoAgarravel obj = hit.collider.GetComponent<ObjetoAgarravel>();

                if(obj != null){

                    objetoNaMao = obj;
                }
            }
    }

    void Soltar(){

        objetoNaMao = null;
    }
    
}
