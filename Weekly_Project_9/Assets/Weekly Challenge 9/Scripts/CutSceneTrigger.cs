using UnityEngine;
using UnityEngine.Playables;

public class CutSceneTrigger : MonoBehaviour
{

    public PlayableDirector cutscene;

    public PlayableDirector _Director;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cutscene.Play();
        }
    }
}
