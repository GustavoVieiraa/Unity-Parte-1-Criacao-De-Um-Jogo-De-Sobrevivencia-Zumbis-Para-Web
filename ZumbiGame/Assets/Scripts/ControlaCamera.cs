using UnityEngine;

public class ControlaCamera : MonoBehaviour
{
    [SerializeField] private GameObject jogador; // Referência ao objeto do jogador
    private Vector3 distanciaCompensar; // Distância entre a câmera e o jogador

    void Start()
    {
        if (jogador == null)
        {
            Debug.LogError("Jogador não atribuído no script ControlaCamera.");
            return;
        }

        // Calcula a distância inicial entre a câmera e o jogador
        distanciaCompensar = transform.position - jogador.transform.position;
    }

    void LateUpdate()
    {
        if (jogador != null)
        {
            // Atualiza a posição da câmera para seguir o jogador
            transform.position = jogador.transform.position + distanciaCompensar;
        }
    }
}
