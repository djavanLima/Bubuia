using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoverObjeto : MonoBehaviour {
    public Pause Pause;
    public float velocidade;
    public float[] rot;
    public Transform[] posicao;
    public bool mover=false;
    public int lance;
    public int guardaPos; // posicao do ultimo transform a ser alcansado
    public int posAtual; // posicao atual do transformer a ser alcansado de um em um
    private int i;
    private bool atualizar=false; //controla a varivel ser utilizada apenas uma vez
    public  ControlP ControlP;
    public bool jogada;
    bool contEncerra;
    int andaUm=0;
    int atual;
    public Animator anime;
    Vector3 distancia;
    Quaternion RotaDir;
    // variável que guarda a ultima posição
    public Transform ultimaPosiçao; 
   
    // instancia a classe pergunta
   public  Responder Responder;


    // variaveis voltar

    public bool voltar = false;
    int voltaUm;
    public int voltAleat;

    //valor boleano para que continue inativo a pergunta após a resposta correta.
    public bool enableResp;
    
    
    //variavel vencedor




    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        int k = 0;
        if (Pause.pause==false) { 

        if (mover == true)
        {

            avanca();
            contEncerra = true;
        }
        else if(mover==false && contEncerra==true)
        {

            ControlP.encerrou = true; // finaliza a rodada
            contEncerra = false;

        }

            /*if (voltar==true)
            {
                retrocede();
            }*/

        }
    }

   
    public void avanca()
    {


        if (posAtual<48)
        {

        

        if (jogada == true)// inicia as posições apenas uma vez para cada jogada
        {
           
            guardaPos = posAtual;
            posAtual += lance;
            andaUm = 0;
                if (posAtual>34 )
                {
                    posAtual = 34;
                }
            jogada = false;

            
        }
        if (transform.position != posicao[posAtual].position)// move a peça enquanto a posição da mesma for diferente da posição sorteada
        {
                atual = guardaPos + andaUm;
                anime.SetBool("andar",true);
            transform.position = Vector2.MoveTowards(transform.position, posicao[guardaPos + andaUm].position, Time.deltaTime * velocidade);


                // Objeto vai olha para o transform
                transform.eulerAngles = new Vector3(rot[atual],90,-90);
                // quando chegar na primeira posicao incremento mais 1
                if (transform.position == posicao[guardaPos + andaUm].position)
            {
                    
                    andaUm++;

            }

        }

        else {
                anime.SetBool("andar",false);
            mover = false;

            ControlP.alet.text = "";
           // ControlP.alet.gameObject.SetActive(false);

           
        }


        }

        if (transform.position==ultimaPosiçao.position) { 
            ControlP.voceGanhou();

            if (gameObject.tag=="Player1")
            {
                ControlP.jogadorVencedor = 1;
            }

            if(gameObject.tag == "Player2")
            {
                ControlP.jogadorVencedor = 2;

            }
            //ativar botão de iniciar jogo 
            //criar um botão de iniciar jogo
            StartCoroutine(gameOver());
        }

    }




    IEnumerator gameOver()
    {
        yield return new WaitForSeconds(1.5f);
        ControlP.gameOver();
    }





    /*
       public void retrocede()
       {


           if (voltar == true)// inicia as posições apenas uma vez para cada jogada
           {
               guardaPos = posAtual;



               posAtual -=  voltAleat;
               voltar = false;
           }

           if (posAtual < 0)
           {
               posAtual = 0;
           }





            transform.position =  posicao[posAtual].position;
               ControlP.encerrou = true;
           Debug.Log("Passou");    
           Debug.Log(ControlP.encerrou);
               voltar = false;







       }

       */
}

