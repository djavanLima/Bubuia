using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlP : MonoBehaviour
{
    // public SomJogo SomJogo;
    public bool piscarSeta=true;
    public bool ganhou;
    public Animator dado;
    public GameObject da;
    public SomJogo SomJogo;
    public static bool som = true;
    public FollowPlayer followPlayer;
    public Text txtJogador;
    public int player;
    public Text alet;
    public MoverObjeto MoverObjeto;
    public Button btnLancar;
    public bool encerrou;
    public GameObject TelaPergunta;
    bool adicionar;
    public GameObject TelaInfo;
    public Responder Responder;
     int i;
    public Pause Pause;
    //objeto temporizador
    public Temporizador tmp;
    //contagem de pontos de quem acertou
    public static int contJog1;
    public static int contJog2;


    //variável vencedor
    public static int jogadorVencedor;
    // Use this for initialization
    void Start()
    {
        alet.text = "Jogador 1:\n clique no botão INICIAR";
        contJog1 = 0;
        contJog2 = 0;

    }
   void FixedUpdate()
    {
        

        
        if (Pause.pause == false)
        {

            if (player == 1)
            {


                MoverObjeto = GameObject.FindWithTag("Player1").GetComponent<MoverObjeto>();// encotra gameObject em cena
               // followPlayer.player = GameObject.FindWithTag("Player1").GetComponent<Transform>(); // pega referencia do player e joga para camera
                txtJogador.text = "Jogador 1";// alterna no nome do jogador vigente
              

                if (encerrou == true)
                {//ao encerrar a jogado do player um, é habilitado o player 2
                     // normaliza os segundos e minutos
                    lancarBool = false;
                    player = 2;
                    TelaInfo.SetActive(true);
                    if (ganhou == false)
                    {
                        alet.text = "Jogador 2:\n clique no botão INICIAR ";
                    }
                        tmp.nomarlizarCronometro();// normaliza os segundos e minutos
                    btnLancar.interactable = true;
                    encerrou = false;

                }
            }
            if (player == 2)
            {

                MoverObjeto = GameObject.FindWithTag("Player2").GetComponent<MoverObjeto>();// encotra gameObject em 
               // followPlayer.player = GameObject.FindWithTag("Player2").GetComponent<Transform>();// do player e joga para camera
                txtJogador.text = "Jogador 2";
               
                if (encerrou == true)//ao encerrar a jogado do player um é habilitado o player 1  

                {
                    
                    lancarBool = false;
                    player = 1;
                    TelaInfo.SetActive(true);
                    if (ganhou==false) { 
                    alet.text = "jogador 1:\n clique em INICIAR";
                    }
                    tmp.nomarlizarCronometro(); // normaliza os segundos e minutos
                    btnLancar.interactable = true;
                    encerrou = false;
                }
            }

          
        }
       
    }

   public bool lancarBool;
    public void Lancar()
    {
        piscarSeta = false;
        SomJogo.clipButton();
        if (Pause.pause == false)
        {
            btnLancar.interactable = false;
            da.SetActive(true);
            i = Random.Range(1, 7);
            TelaInfo.SetActive(false);
            StartCoroutine( animationDado(i));
           

            
            if (i != 1)
            {
                alet.text = "Você vai avançar " + i.ToString() + " casas se acertar a pergunta";
            }
            else
            {
                alet.text = "Você vai avançar " + i.ToString() + " casa se acertar a pergunta";

            }

            lancarBool = true;
           
                
           


        }

      
    



    }

    IEnumerator animationDado(int alet )
    {
        if (alet == 1)
        {
            dado.SetInteger("dado", 1);
        }
        if (alet == 2)
        {
            dado.SetInteger("dado", 2);
        }
        if (alet == 3)
        {
            dado.SetInteger("dado", 3);
        }
        if (alet == 4)
        {
            dado.SetInteger("dado", 4);
        }
        if (alet == 5)
        {
            dado.SetInteger("dado", 5);
        }
        if (alet == 6)
        {
            dado.SetInteger("dado", 6);
        }

        yield return new WaitForSeconds(3.0f);
        TelaInfo.SetActive(true);
        StartCoroutine(pauseAtivar());
    }

 

    //função para mostrar pergunta com atraso de tempo
    IEnumerator pauseAtivar()
    {

        yield return new WaitForSeconds(4);



        if (Pause.pause == false)
        {
            dado.SetInteger("dado", 0);
            da.SetActive(false);
            TelaInfo.SetActive(false);
            ativarPergunta();
        }
        else {

            StartCoroutine(pauseAtivar());
        }


    }


    public void Mover()
    {
        //soma os pontos de quem acertou
        if (player==1)
        {
            contJog1++;
            Debug.Log("ponto jogador 1 "+ contJog1);
        }
        if (player==2)
        {
            contJog2++;
            Debug.Log("ponto jogador 2 " + contJog2);
        }


        MoverObjeto.enableResp = false;// variavel para ativar a pergunta
        StartCoroutine(valor());// rotina para que p yield for seconds funcione
        
          
        
        //   MoverObjeto.andar(i);
    }
    IEnumerator valor()
    {
        TelaInfo.SetActive(true);
        alet.text = "Parabéns você acertou...";
        yield return new WaitForSeconds(2.0f);
        TelaInfo.SetActive(false);
        MoverObjeto.mover = true;
        MoverObjeto.jogada = true;
      Debug.Log(  MoverObjeto.lance = i);
    }

    /// avança se acertar a resposta


    public void errou()
    {
        TelaInfo.SetActive(true);
        alet.text = "Você errou. Continue tentando...";
        
        StartCoroutine(vErrou());
    }
    IEnumerator vErrou()
    {
        if (Pause.pause==false) { 
        yield return new WaitForSeconds(1.5f);
        TelaInfo.SetActive(false);
        encerrou = true;
            // volta de forma aleatória
        }
    }

    //funcao que comanda o erro
    /* public void errou()
     {
         MoverObjeto.enableResp = true;
         int j = Random.Range(1, 5);
         alet.text = "Você errou, retorne " + j.ToString() + " casa(s)";
         alet.gameObject.SetActive(true);

         StartCoroutine(vErrou(j));
     }
     IEnumerator vErrou(int j)
     {
         yield return new WaitForSeconds(1.5f);

         MoverObjeto.voltAleat = j;// volta de forma aleatória
         MoverObjeto.voltar = true;
     }

     */
    //funcao ativa tela
    public void ativarPergunta()
    {
        Temporizador.pergunta = true;
        TelaPergunta.SetActive(true);
        clicou.perguntaAtiva = true;
        Responder.updatePergunta();
   

    }

    public void voceGanhou() {
        ganhou = true;
        TelaInfo.SetActive(true);
        alet.text = "Voce ganhou!!!!";
        btnLancar.interactable = false;
    }

    public static int countj1;
    public static int countj2;

    public static void gameOver()
    {

        countj1=contJog1;
        countj2=contJog2;
        SceneManager.LoadScene("gameOver");
    }

    // Update is called once per frame
}
