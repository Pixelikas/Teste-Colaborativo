using UnityEngine;
public class Player : MonoBehaviour
{
    int contagem = 0;

    void Start()
    {
     DEbug.Log("OI")
    }

    void Update()
    {

    }

    void OnMouseOver()
    {
        contagem++;
        Debug.Log("Mouse por cima " + contagem + " vezes!");
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Nome do chão: " + col.gameObject.name);
        Debug.Log("Nome do Player" + gameObject.name);
        Destroy(gameObject);
        Destroy(col.gameObject);
    }

}
