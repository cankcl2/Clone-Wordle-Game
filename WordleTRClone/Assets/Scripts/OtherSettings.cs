using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherSettings : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject _on;
    public GameObject _off;
    public GameObject musicPlayer;

    private void Start()
    {
        _on.SetActive(true);
        _off.SetActive(false);
        settingsPanel.SetActive(false);
    }
    public void SettingsButton()
    {
        settingsPanel.SetActive(true);
    }
    public void OnToOff()
    {
        musicPlayer.GetComponent<AudioSource>().Stop();
        _on.SetActive(false);
        _off.SetActive(true);
    }
    public void OffToOn()
    {
        musicPlayer.GetComponent<AudioSource>().Play();
        _on.SetActive(true);
        _off.SetActive(false);
    }
    public void CloseSettingsPanel()
    {
        settingsPanel.SetActive(false);
    }
}
