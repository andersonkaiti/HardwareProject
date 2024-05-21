using UnityEngine;
using UnityEngine.UI;

public class Mensagem : MonoBehaviour {
    // Declaração a variável de referência do texto
    public Text text;
    public GameObject Panel;
    // Declaração e inicialização da variável de distância do objeto com um range entre 0.1 a 10
    [Range(0.1f, 10.0f)]public float distancia = 3;
    // Declaração da variável de referência do jogador
    private GameObject Player;

    void Start() {
        // Inicializa a variável jogador com o objeto que contém a tag Player
        Player = GameObject.FindWithTag("Player");
        // Desativa o texto inicialmente
        if (text) {
            text.enabled = false;
        }
    }

    void Update() {
        if(text && Panel && Player) {
            /*
               Realiza a comparação da posição do objeto e do jogador,
               verificando se ela é menor que a variável distância,
               e verifica se a tecla Tab está sendo pressionada.
               Caso as condições sejam verdadeiras, a mensagem será exibida na tela
            */
            if((Vector3.Distance(transform.position, Player.transform.position) < distancia)) {
                Panel.SetActive(true);
                text.enabled = true;
            } else {
                Panel.SetActive(false);
                text.enabled = false;
            }
        }
    }
}