using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public static UI Instance;
    public AudioClip m_musicClip;//背景音乐
    public AudioSource m_Audio;//声音源
    public Transform canvas;//开始界面
	// Use this for initialization
	void Start () {
        Instance = this;
        m_Audio = this.gameObject.AddComponent<AudioSource>();//使用代码添加音效组件
        m_Audio.clip = m_musicClip;//指定音效
        m_Audio.loop = true;//循环播放
        m_Audio.Play();//播放音乐

        var restart_botton = canvas.transform.Find("Button").GetComponent<Button>();
        restart_botton.onClick.AddListener(delegate ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);//重新开始关卡
        }

        );
            {

        }
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
