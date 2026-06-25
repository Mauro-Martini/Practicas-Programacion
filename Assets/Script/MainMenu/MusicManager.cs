using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instancia;
    public AudioSource musicSource;
    public VolumeSettings volumeSettings;
   
    void Awake()
    {
        if (instancia != null)
        {
            Destroy(gameObject);
            return;
        }
        instancia = this;
        DontDestroyOnLoad(gameObject);

        musicSource.volume = volumeSettings.volumen;
    }

    public void SetVolume(float volumen)
    {
        musicSource.volume = volumen;
        volumeSettings.volumen = volumen;
        
    }
}