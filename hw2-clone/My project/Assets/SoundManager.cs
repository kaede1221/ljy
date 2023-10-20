using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance; // 单例实例

    [SerializeField] AudioClip footstepSound;
    [SerializeField] AudioClip backgroundMusicSound;

    private AudioSource backgroundMusicSource;
    private AudioSource footstepAudioSource;

    private bool isBackgroundMusicPlaying = false;
    private bool isFootstepSoundPlaying = false;

    private void Awake()
    {  Debug.Log("1");
        // 创建单例
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 保持声音管理器在场景切换时不被销毁
        }

        backgroundMusicSource = gameObject.AddComponent<AudioSource>();
        footstepAudioSource = gameObject.AddComponent<AudioSource>();

        backgroundMusicSource.clip = backgroundMusicSound;
        footstepAudioSource.clip = footstepSound;
    }

    void Start()
    {
        Debug.Log("2");
        PlayBackgroundMusic();
        Debug.Log("3");
    }

    private void Update()
    {
        PlayerMovement player = PlayerMovement.instance;
        if (player != null)
        {
            // 根据玩家是否移动来播放或停止脚步声音
            if (player.GETifplayerMoving())
            {
                PlayFootstepSound();
            }
            else
            {
                StopFootstepSound();
            }
        }
    }
    public void PlayFootstepSound()
    {
        if (!isFootstepSoundPlaying)
        {
            footstepAudioSource.Play();
            isFootstepSoundPlaying = true;
        }
    }

    public void StopFootstepSound()
    {
        if (isFootstepSoundPlaying)
        {
            footstepAudioSource.Stop();
            isFootstepSoundPlaying = false;
        }
    }

    public void PlayBackgroundMusic()
    {
        if (!isBackgroundMusicPlaying)
        {
            backgroundMusicSource.Play();
            isBackgroundMusicPlaying = true;
        }
    }

    public void StopBackgroundMusic()
    {
        if (isBackgroundMusicPlaying)
        {
            backgroundMusicSource.Stop();
            isBackgroundMusicPlaying = false;
        }
    }

    public bool IsBackgroundMusicPlaying()
    {
        return isBackgroundMusicPlaying;
    }

    public bool IsFootstepSoundPlaying()
    {
        return isFootstepSoundPlaying;
    }
}
