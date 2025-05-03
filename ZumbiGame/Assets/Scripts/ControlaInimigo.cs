using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{
    [SerializeField] private GameObject jogador; // Referência ao objeto do jogador
    [SerializeField] private float velocidade = 5f; // Velocidade do inimigo
    private Rigidbody rb; // Cache do Rigidbody

    void Start()
    {
        // Cache do Rigidbody para evitar chamadas repetitivas
        rb = GetComponent<Rigidbody>();

        // Validação para garantir que o jogador foi atribuído
        if (jogador == null)
        {
            Debug.LogError("Jogador não atribuído no script ControlaInimigo.");
        }
    }

    void FixedUpdate()
    {
        if (jogador == null) return; // Evita erros caso o jogador não esteja atribuído

        // Calcula a direção do movimento
        Vector3 direcao = (jogador.transform.position - transform.position).normalized;

        // Move o inimigo na direção do jogador
        rb.MovePosition(rb.position + direcao * velocidade * Time.deltaTime);
    }
}
