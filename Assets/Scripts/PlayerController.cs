using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
    - Acessar o Rigidbody 2D
    - Acessar as setinhas do teclado (<, >, /\, \/)
    - Movimentar o Rigidbody de acordo com as setinhas pressionadas
    */

    // Variável: Tipo e Nome
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Pegamos o componente Rigidbody2D que está no mesmo objeto
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Seta para esquerda, valor do H = -1
        // Seta para direita, valor do H = 1
        var h = Input.GetAxis("Horizontal");

        // Seta para cima, valor do V = 1
        // Seta para baixo, valor do V = -1
        var v = Input.GetAxis("Vertical");

        // Movimentamos o Rigidbody alterando sua velocidade
        // A velocidade do Rigidbody possui dois eixos: X (esq/dir) e Y (cima/baixo)
        // Representamos a velocidade X e Y em um Vector2(x, y)
        rb.velocity = new Vector2(h, v);
    }
}
