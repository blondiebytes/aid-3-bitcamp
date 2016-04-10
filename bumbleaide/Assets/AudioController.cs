using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {
    
    AudioSource source;
    public int delay;
    int index = 1;

	// Use this for initialization
	void Start () {
        source = this.GetComponent<AudioSource>();
        source.PlayDelayed(delay);
      //  GameObject child;
     //   child = new GameObject("Sound");
      //  child.transform.parent = this.transform;
      //  source = child.AddComponent<AudioSource>();
     //   source.PlayOneShot(clips[0]);
    //    for (int i = 1; i < clips.Length; i++)
    //    {
    //        playAudio(Waiting());
    //    }
    }

   // void playAudio(IEnumerator e)
  //  {
  //      source.PlayOneShot(clips[index]);
  //      index++;
 //   }

  //  public IEnumerator Waiting()
  //  {
 //       yield return new WaitForSeconds(10);
 //   }
//

	
	// Update is called once per frame
	void Update () {
	
	}
}
