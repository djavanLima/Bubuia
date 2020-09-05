using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectionScene : MonoBehaviour {

    //declaration gameObjects
   
    //declaration variables

    public string[] alternativasA; //armazenas todas alternativas A
    public string[] alternativasB; //armazenas todas alternativas B
    public string[] alternativasC;
    // declaration variables type text
    public Text q1;
    public Text q2;
    public Text q3;
    string ano;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void selecionarAno(string ano)
    {


        if (ano == "2")
        {
            q1.text = alternativasA[0];
            q2.text = alternativasB[0];
            q3.text = alternativasC[0];
            this.ano = ano;
        }

        if (ano == "3")
        {
            q1.text = alternativasA[1];
            q2.text = alternativasB[1];
            q3.text = alternativasC[1];
            this.ano = ano;

        }

        if (ano == "4")
        {
            q1.text = alternativasA[2];
            q2.text = alternativasB[2];
            q3.text = alternativasC[2];
            this.ano = ano;
        }

        if (ano == "5")
        {
            q1.text = alternativasA[3];
            q2.text = alternativasB[3];
            q3.text = alternativasC[3];
            this.ano = ano;
        }

       


    }

    public void selectiorQuestion(string question)
{
        // second year
        if (ano=="2" && question=="1")
        {
            SceneManager.LoadScene("Jogar");
        }

        if (ano == "2" && question == "2")
        {
            SceneManager.LoadScene("Jogar 1");
        }

        if (ano == "2" && question == "3")
        {
            SceneManager.LoadScene("Jogar 2");
        }
        // third year
        if (ano == "3" && question == "1")
        {
            SceneManager.LoadScene("Jogar 3");
        }

        if (ano == "3" && question == "2")
        {
            SceneManager.LoadScene("Jogar 4");
        }

        if (ano == "3" && question == "3")
        {
            SceneManager.LoadScene("Jogar 5");
        }


        //forth year
        if (ano == "4" && question == "1")
        {
            SceneManager.LoadScene("Jogar 6");
        }

        if (ano == "4" && question == "2")
        {
            SceneManager.LoadScene("Jogar 7");
        }

        if (ano == "4" && question == "3")
        {
            SceneManager.LoadScene("Jogar 8");
        }

        //quinto year
        if (ano == "5" && question == "1")
        {
            SceneManager.LoadScene("Jogar 9");
        }

        if (ano == "5" && question == "2")
        {
            SceneManager.LoadScene("Jogar 10");
        }

        if (ano == "5" && question == "3")
        {
            SceneManager.LoadScene(12);
        }

    }
}
