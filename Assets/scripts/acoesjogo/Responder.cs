using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Responder : MonoBehaviour {
    // variaveis que vam comportara as alternativas
    public SomJogo SomJogo;
    public Text txtPergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    
    public string[] perguntas; //armazenas todas as perguntas
    public int quantPergunt;
    private int idPergunta;// a pergunta e as respostas estarão relacionadas ao Id
    //vai guardar a quantidade das questões
    private int questoes;
    //esse é o pequeno banco virtual de perguntas substituir por banco de dados no final
   
    public string[] alternativasA; //armazenas todas alternativas A
    public string[] alternativasB; //armazenas todas alternativas B
    public string[] alternativasC; //armazenas todas alternativas C
    public string[] alternativasD; //armazenas todas alternativas D
    public string[] corretas; //armazenas todas as perguntas

    private int acertos;
    public bool acertou;
    // pontuação dos jogadores 
    int contJog1;
    int contJog2;

    //instancia Controlp para acessar suas variaveis 
    public ControlP ControlP;

    public Pause Pause;
    // Use this for initialization
    void Start () {


        if (Pause.pause==false) { 
        idPergunta = Random.Range(0,quantPergunt); //quantidade de perguntas, onde será realizado o range entre eles 
        questoes = perguntas.Length; // informa a quantidade de perguntas
        embaralhar();
        txtPergunta.text = perguntas[idPergunta];
        respostaA.text = alternativasA[idPergunta];// prenche A
        respostaB.text = alternativasB[idPergunta];//preenche B
        respostaC.text = alternativasC[idPergunta];//preenche c
        respostaD.text = alternativasD[idPergunta];// preenche D
        }
    }

    public void updatePergunta()
    {
        if (Pause.pause==false) {
            idPergunta = Random.Range(0, quantPergunt); //quantidade de perguntas, onde será realizado o range entre eles 
            questoes = perguntas.Length; // informa a quantidade de perguntas
                embaralhar();
                txtPergunta.text = perguntas[idPergunta];
                respostaA.text = alternativasA[idPergunta];// prenche A
                respostaB.text = alternativasB[idPergunta];//preenche B
                respostaC.text = alternativasC[idPergunta];//preenche c
                respostaD.text = alternativasD[idPergunta];// preenche D
            }

    }



    public void compResposta(string alternativa)// funcao chamada pelo botão
    {
        SomJogo.clipButton();
        if (Pause.pause == false)
        {

            if (alternativa == "A") // cada letra comprende a um evento enviado pelo botão
            {
                if (alternativasA[idPergunta] == corretas[idPergunta])// compara a afirmativa  A com a resposta correta
                {
                    ControlP.Mover();

                


                    Debug.Log("acertou");
                }

                else
                {
                    ControlP.errou();
                }
                clicou.respondeu = true;
            }

            else if (alternativa == "B")
            {
                if (alternativasB[idPergunta] == corretas[idPergunta])// compara a afirmativa  B com a resposta correta
                {


                    ControlP.Mover();
                    Debug.Log("acertou");
                }

                else
                {
                    Debug.Log("errou");
                    ControlP.errou();
                }
                clicou.respondeu = true;
            }


            else if (alternativa == "C")
            {

                if (alternativasC[idPergunta] == corretas[idPergunta])// compara a afirmativa  C com a resposta correta
                {
                    ControlP.Mover();
                    Debug.Log("acertou");
                }

                else
                {
                    Debug.Log("errou");
                    ControlP.errou();
                }
                clicou.respondeu = true;
            }

            else if (alternativa == "D") // compara a afirmativa  D com a resposta correta
            {

                if (alternativasD[idPergunta] == corretas[idPergunta])
                {
                    ControlP.Mover();
                    Debug.Log("acertou");
                }

                else
                {

                    Debug.Log("errou");
                    ControlP.errou();
                }
                clicou.respondeu = true;
            }


            ControlP.TelaPergunta.SetActive(false);
            Temporizador.pergunta = false;

        }

    }

    void embaralhar() {// alternativas mandadas para serem embaralhadas
        string[] alet= new string[4];
        int i;
        alet[0]=alternativasA[idPergunta];
        alet[1]=alternativasB[idPergunta];
        alet[2]=alternativasC[idPergunta];
        alet[3]=alternativasD[idPergunta];

        

        recBaralhar( alet);





    }

    void recBaralhar(string[] alet)// funcção para embaralhar as alternativas
    {
        int a,j;
        int b;
        int c;
        int d;
        string[] temp = new string[4];// cria range aleatório para que não haja nenhuma repetição
                                      /* temp[0] = alet[Random.Range(0, 4)];
                                       temp[1] = alet[Random.Range(0, 4)];
                                       temp[2] = alet[Random.Range(0, 4)];
                                       temp[3] = alet[Random.Range(0, 4)];*/

        /*    if ((temp[0] != temp[1] && temp[0] != temp[2] && temp[0] != temp[3]) &&
                (temp[1] != temp[2] && temp[1] != temp[3]) &&
                (temp[2] != temp[3])

                )
            {
                alternativasA[idPergunta] = temp[0];
                alternativasB[idPergunta] = temp[1];
                alternativasC[idPergunta] = temp[2];
                alternativasD[idPergunta] = temp[3];

            }
            else
            {
                recBaralhar(alet);

            }*/
        /*
    while ((temp[0] != temp[1] && temp[0] != temp[2] && temp[0] != temp[3]) &&
        (temp[1] != temp[2] && temp[1] != temp[3]) &&
        (temp[2] != temp[3])) 
    {
        if ((temp[0] != temp[1] && temp[0] != temp[2] && temp[0] != temp[3]) &&
        (temp[1] != temp[2] && temp[1] != temp[3]) &&
        (temp[2] != temp[3])) { 
            temp[0] = alet[Random.Range(0, 4)];
        temp[1] = alet[Random.Range(0, 4)];
        temp[2] = alet[Random.Range(0, 4)];
        temp[3] = alet[Random.Range(0, 4)];
        Debug.Log("palmeiras");
     }
    }
    */
       

        a = Random.Range(0, 4);
        b = Random.Range(0, 4);
        c = Random.Range(0, 4);
        d = Random.Range(0, 4);


        while ((a == b || a == c || a == d)||
           (b == c || b == d) ||
           (c == d)) {

            a =Random.Range(0, 4);
            b= Random.Range(0, 4);
            c = Random.Range(0, 4);
            d = Random.Range(0, 4);
            Debug.Log("palmeiras");
        }
        temp[0] = alet[0];
        temp[1] = alet[1];
        temp[2] = alet[2];
        temp[3] = alet[3];


    }






}
