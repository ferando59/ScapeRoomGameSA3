using UnityEngine;

public class paperHolderScripts : MonoBehaviour
{

    public int horas = 0;
    public bool papelFoiIncerido = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other){
        if(papelFoiIncerido == true){

        if(other.CompareTag("atividade5")){

            horas = 5;

        }

        if(other.CompareTag("atividade8")){

            horas = 8;

        }

        if(other.CompareTag("atividade6")){

            horas = 6;

        }

        if(other.CompareTag("atividade2")){

            horas = 2;

        }

        if(other.CompareTag("atividade1")){

            horas = 1;

        }

        if(other.CompareTag("atividade7")){

            horas = 7;

        }

        if(other.CompareTag("atividade3")){

            horas = 3;

        }

        }
        
    }

    void OnTriggerExit(Collider other){
        if(papelFoiIncerido == true){

        if(other.CompareTag("atividade5") || other.CompareTag("atividade8") || other.CompareTag("atividade6") || other.CompareTag("atividade2") || other.CompareTag("atividade1") || other.CompareTag("atividade7") || other.CompareTag("atividade3")){

            horas = 0;

        }

        }
        
    }
}
