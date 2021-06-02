using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class spin : MonoBehaviour
{

    private int randomValue;
    private float timeInterval;
    private bool coroutineAllowed;
    private int finalAngle;
    public InputField iField;

    public Text winText;
    public Text nText;

    // Start is called before the first frame update
    private void Start()
    {
        coroutineAllowed = true;
        iField = gameObject.GetComponent<InputField>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && coroutineAllowed)
            StartCoroutine(Spin());
    }

    private IEnumerator Spin()
    {
        coroutineAllowed = false;
        randomValue = Random.Range(20, 30);
        timeInterval = 0.1f;

        int rand_num = Random.Range(1, 10);

        if(rand_num >= 1 && rand_num <= 8)
        {
            switch (3)
            {
                case 1:
                    winText.text = "You got 1";
                    break;
                case 2:
                    winText.text = "You got 2";
                    break;
                case 3:
                    winText.text = "You got 3";
                    break;
                case 4:
                    winText.text = "You got 4";
                    break;
                case 5:
                    winText.text = "You got 5";
                    break;
                case 6:
                    winText.text = "You got 6";
                    break;
                case 7:
                    winText.text = "You got 7";
                    break;
                case 8:
                    winText.text = "You got 8";
                    break;
            }
        }


        for (int i = 0; i < randomValue; i++)
        {
            transform.Rotate(0, 0, 22.5f);
            if (i > Mathf.RoundToInt(randomValue * 0.5f))
                timeInterval = 0.2f;
            if (i > Mathf.RoundToInt(randomValue * 0.85f))
                timeInterval = 0.4f;
            yield return new WaitForSeconds(timeInterval);
        }

        if (Mathf.RoundToInt(transform.eulerAngles.z) % 45 != 0)
            transform.Rotate(0, 0, 22.5f);

        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);

        switch (finalAngle)
        {
            case 0:
                winText.text = "You got 1";
                break;
            case 45:
                winText.text = "You got 2";
                break;
            case 90:
                winText.text = "You got 3";
                break;
            case 135:
                winText.text = "You got 4";
                break;
            case 180:
                winText.text = "You got 5";
                break;
            case 225:
                winText.text = "You got 6";
                break;
            case 270:
                winText.text = "You got 7";
                break;
            case 315:
                winText.text = "You got 8";
                break;
        }

        coroutineAllowed = true;
    }
}
