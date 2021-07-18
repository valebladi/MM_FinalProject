using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;

public class Voice : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, System.Action> actions = new Dictionary<string, System.Action>();
    // Start is called before the first frame update
    void Start()
    {
        //actions.Add("jump",Jump);
        

       keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
       keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
       keywordRecognizer.Start();
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 1250);

    }
}
