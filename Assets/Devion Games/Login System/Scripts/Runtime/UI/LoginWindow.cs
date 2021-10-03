using DevionGames.UIWidgets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace DevionGames.LoginSystem
{
    public class LoginWindow : UIWidget
    {

        [SerializeField]
        private string escena;
        [SerializeField]
        private Text username;
        [SerializeField]
        private Text password;
        [SerializeField]
        protected Toggle rememberMe;
        [SerializeField]
        protected Button loginButton;
        [SerializeField]
        protected GameObject loadingIndicator;

        void Start()
        {
            username.text = PlayerPrefs.GetString("username", string.Empty);
            password.text = PlayerPrefs.GetString("password", string.Empty);

            if (rememberMe != null)
            {
                rememberMe.isOn = string.IsNullOrEmpty(username.text) ? false : true;
            }
          
            if (loadingIndicator != null){
                loadingIndicator.SetActive(false);
            }

        }

        public void OnLogin() {
            if (rememberMe != null && rememberMe.isOn)
            {
                PlayerPrefs.SetString("username", username.text);
                PlayerPrefs.SetString("password", password.text);
            }
            else
            {
                PlayerPrefs.DeleteKey("username");
                PlayerPrefs.DeleteKey("password");
            }
            SceneManager.LoadScene(escena);
        }

    }
}