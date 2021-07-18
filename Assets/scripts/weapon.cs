using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;


public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, System.Action> actions = new Dictionary<string, System.Action>();
   
    void Start()
    {
       actions.Add("shoot",Shoot);
       keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
       keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
       keywordRecognizer.Start();
    }

    
    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log("Voice: "+speech.text);
        actions[speech.text].Invoke();
    }

    private void Shoot()
    {
        Instantiate(bullet, firePoint.position,firePoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    
}
