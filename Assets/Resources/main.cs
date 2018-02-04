using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {

    //Menu Utama
    public void GoToMainMenu()
    {
        Application.LoadLevel("main");
    }

    //Materi
    public void GoToMateri1()
    {
        Application.LoadLevel("materi1");
    }
    public void GoToMateri2()
    {
        Application.LoadLevel("materi2");
    }

    //Praktik AR
    public void GoToARCamera()
    {
        Application.LoadLevel("carlearning");
    }

    //Bantuan
    public void GoToBantuan()
    {
        Application.LoadLevel("bantuan");
    }

    //Tentang
    public void GoToTentang()
    {
        Application.LoadLevel("tentang");
    }

    //Keluar
    public void ExitApplication()
    {
        Application.Quit();
    }
}
