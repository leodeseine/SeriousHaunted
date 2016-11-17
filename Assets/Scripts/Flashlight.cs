
using UnityEngine;

public class Flashlight : MonoBehaviour
{
        private const byte INTENSITY_ON = 5;
    private const byte INTENSITY_OFF = 0;
		private bool on = false;
        public GameObject text; 
		void Start ()
		{
				gameObject.GetComponent<Light>().intensity = INTENSITY_OFF;
		}

		void Update ()
		{
			if (Input.GetKeyDown(KeyCode.F)) {
            on = !on;
            text.SetActive(false); // Pour le début
        }

		}

    void OnGUI()
    {
        if (!on)
        {
            gameObject.GetComponent<Light>().intensity = INTENSITY_ON;
            on = !on;
        }
        else
        {
            gameObject.GetComponent<Light>().intensity = INTENSITY_OFF;
            on = !on;
        }
    }
}
