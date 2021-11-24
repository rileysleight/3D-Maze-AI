using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Crystals : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI jewelsLeft;
    [SerializeField] TextMeshProUGUI collected;

    int jLeft = 24;
    int jCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        jewelsLeft.text = (jLeft.ToString());
        collected.text = (jCollected.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        jewelsLeft.text = (jLeft.ToString());
        collected.text = (jCollected.ToString());

        if (jLeft == 0)
        {
            SceneManager.LoadScene(2);
        }
    }

        void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Crystal"))
        {
            print("Crystal");
            jLeft = jLeft - 1;
            jCollected = jCollected + 1;
            Destroy(other.gameObject);
        }
    }

}
