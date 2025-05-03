using UnityEngine;

public class ControlaJogador : MonoBehaviour
{
    public float velocidade = 10f;
    private Animator animator;
    private Vector3 direcao;

    void Start()
    {
        // Cache do componente Animator para evitar chamadas repetitivas
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Captura dos eixos de entrada
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        // Calcula a direção do movimento
        direcao = new Vector3(eixoX, 0, eixoZ);
    }

    void FixedUpdate()
    {
        // Movimenta o jogador
        Mover(direcao);

        // Atualiza o estado da animação
        AtualizarAnimacao(direcao);
    }

    private void Mover(Vector3 direcao)
    {
        GetComponent<Rigidbody>().MovePosition
        (GetComponent<Rigidbody>().position +
        (direcao * velocidade * Time.deltaTime));
    }

    private void AtualizarAnimacao(Vector3 direcao)
    {
        bool estaMovendo = direcao != Vector3.zero;
        animator.SetBool("Movendo", estaMovendo);
    }
}
