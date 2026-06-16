using UnityEngine;

public class PlayerVision : MonoBehaviour
{
    public Transform visorOrigem; // A c�mera ou posi��o dos olhos
    public float distanciaVisao = 10f;
    public LayerMask layerObstaculos; // Camada para paredes/objetos
    public HeandScript heand;
    void Update()
    {
        // 1. Define a dire��o do raio (frente do player)
        Vector3 direcao = visorOrigem.forward;

        // 2. Armazena informa��es da colis�o
        RaycastHit hit;

        // 3. Lan�a o raio (Raycast)
        if (Physics.Raycast(visorOrigem.position, direcao, out hit, distanciaVisao, layerObstaculos))
        {
            // O raio atingiu algo
            Debug.DrawLine(visorOrigem.position, hit.point, Color.red);
            Debug.Log("Olhando para: " + hit.collider.name);
            if(hit.collider.name == "CaixaDeAtividades"){

                heand.coletarAtividades();

            }
        }
        else
        {
            // O raio n�o atingiu nada
            Debug.DrawLine(visorOrigem.position, visorOrigem.position + direcao * distanciaVisao, Color.green);
        }
    }
}
