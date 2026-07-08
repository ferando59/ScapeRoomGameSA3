using UnityEngine;
using TMPro;

public class ClockScripts : MonoBehaviour
{
   public GameObject holder1;
   public GameObject holder2;
   public GameObject holder3;
   public GameObject holder4;
   public GameObject holder5;
   public GameObject holder6;

   public TMP_Text NumeroNoRelogio;

   public GameObject roomRaiva;

   public int hora1 = 0;
   public int hora2 = 0;
   public int hora3 = 0;
   public int hora4 = 0;
   public int hora5 = 0;
   public int hora6 = 0;

   public int horasTotais;

    void Start()
    {
        
    }

    
    void Update()
    {



        hora1 = holder1.GetComponent<paperHolderScripts>().horas;
        hora2 = holder2.GetComponent<paperHolderScripts>().horas;
        hora3 = holder3.GetComponent<paperHolderScripts>().horas;
        hora4 = holder4.GetComponent<paperHolderScripts>().horas;
        hora5 = holder5.GetComponent<paperHolderScripts>().horas;
        hora6 = holder6.GetComponent<paperHolderScripts>().horas;

        horasTotais = hora1 + hora2 + hora3 + hora4 + hora5 + hora6;

        if(horasTotais == 24){

            roomRaiva.GetComponent<roomRaivaScripts>().puzzDone = true;

        }

        NumeroNoRelogio.text = horasTotais + ":00";
    }
}
