using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    //Ang
    public float xRot_Tab;
    public float yRot_Tab;
    public float zRot_Tab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotacao_Tabuleiro
        RotacaoTab();
        InputDeRotacaoX();
        InputDeRotacaoZ();

     }

    //Metodo para preset dos vetores de rotacao do tabuleiro
    void RotacaoTab()
    {
       //transform.rotation = Quaternion.Euler(xRot_Tab,0,zRot_Tab);
       transform.eulerAngles = new Vector3(xRot_Tab,0,zRot_Tab);
    }
    
    //Reconhece o pressionamento do Botao e Rotaciona no eixo X
    void InputDeRotacaoX()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            xRot_Tab += 8f*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            xRot_Tab -= 8f*Time.deltaTime;
        }
    }

    //Reconhece o pressionamento do Botao e Rotaciona no eixo Z
    void InputDeRotacaoZ()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            zRot_Tab -= 8f*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            zRot_Tab += 8f*Time.deltaTime;
        }
    }
}
