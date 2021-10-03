using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

    Animator anim;

    private string escena;
    public int quickSaveSlotID;
    [SerializeField]
    private Text TextSimulacion1;
    [SerializeField]
    private Text TextSimulacion2;
    [SerializeField]
    private Text TextSimulacion3;


    [Header("Options Panel")]
    public GameObject MainOptionsPanel;
    public GameObject LoadGamePanel;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

        //new key
        PlayerPrefs.SetInt("quickSaveSlot", quickSaveSlotID);
    }

    #region Open Different panels

    public void openContinue_Load()
    {
        //enable respective panel
        MainOptionsPanel.SetActive(false);
        LoadGamePanel.SetActive(true);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");

        //play click sfx
        //playClickSound();

    }

    public void newGame()
    {
        if (!string.IsNullOrEmpty(escena))
            SceneManager.LoadScene(escena);
        else
            Debug.Log("Please write a scene name in the 'newGameSceneName' field of the Main Menu Script and don't forget to " +
                "add that scene in the Build Settings!");
    }
    #endregion

    #region Back Buttons

    public void Quit()
    {
        Application.Quit();
    }
    #endregion

    #region Sounds
    public void playHoverClip()
    {
       
    }

    void playClickSound() {

    }


    #endregion

        public void back_options()
    {
        //simply play anim for CLOSING main options panel
        anim.Play("buttonTweenAnims_off");

        //disable BLUR
       // Camera.main.GetComponent<Animator>().Play("BlurOff");

        //play click sfx
    }

    public void elegirSimulacion(int i){
        if (i == 1){
            escena = TextSimulacion1.text;
        }
        else
            if (i == 2){
                escena = TextSimulacion2.text;
            }
            else
            {
                escena = TextSimulacion3.text;
            }
        Debug.Log("la simulacion elegida es "+escena);

        MainOptionsPanel.SetActive(true);
        LoadGamePanel.SetActive(false);

        //play anim for opening game options panel
        anim.Play("OptTweenAnim_on");
    }

}
