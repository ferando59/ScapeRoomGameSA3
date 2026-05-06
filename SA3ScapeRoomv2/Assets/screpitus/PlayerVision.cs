using UnityEngine;

public class PlayerVision : MonoBehaviour
{
    public Transform visorOrigem; // A câmera ou posição dos olhos
    public float distanciaVisao = 10f;
    public LayerMask layerObstaculos; // Camada para paredes/objetos
    void Update()
    {
        // 1. Define a direção do raio (frente do player)
        Vector3 direcao = visorOrigem.forward;

        // 2. Armazena informações da colisão
        RaycastHit hit;

        // 3. Lança o raio (Raycast)
        if (Physics.Raycast(visorOrigem.position, direcao, out hit, distanciaVisao, layerObstaculos))
        {
            // O raio atingiu algo
            Debug.DrawLine(visorOrigem.position, hit.point, Color.red);
            Debug.Log("Olhando para: " + hit.collider.name);
        }
        else
        {
            // O raio não atingiu nada
            Debug.DrawLine(visorOrigem.position, visorOrigem.position + direcao * distanciaVisao, Color.green);
        }
    }
}
