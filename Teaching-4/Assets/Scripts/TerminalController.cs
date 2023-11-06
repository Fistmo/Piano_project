using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using TechTweaking.Bluetooth;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TerminalController : MonoBehaviour
{

	public Text devicNameText;
	public Text status;
	public ScrollTerminalUI readDataText;
	
	public GameObject InfoCanvas;
	public GameObject DataCanvas;
	private  BluetoothDevice device;
	public Text dataToSend;

	void Awake ()
	{
		DontDestroyOnLoad(this);
		Time.timeScale = 1f;

		BluetoothAdapter.askEnableBluetooth ();
		BluetoothAdapter.OnDeviceOFF += HandleOnDeviceOff;
		BluetoothAdapter.OnDevicePicked += HandleOnDevicePicked;

	}
	
	void HandleOnDeviceOff (BluetoothDevice dev)
	{
		if (!string.IsNullOrEmpty (dev.Name))
			status.text = "Couldn't connect to " + dev.Name + ", device might be OFF";
		else if (!string.IsNullOrEmpty (dev.MacAddress)) {
			status.text = "Couldn't connect to " + dev.MacAddress + ", device might be OFF";
		} 
	}

	void HandleOnDevicePicked (BluetoothDevice device)
	{
		this.device = device;
		device.ReadingCoroutine = ManageConnection;

		devicNameText.text = "Remote Device : " + device.Name;
		
	}

	public void showDevices ()
	{
		BluetoothAdapter.showDevices ();
	}
	
	public void connect ()
	{
		SceneManager.LoadScene(1);
		if (device != null) {
			device.connect ();
			status.text = "Trying to connect...";
		}
	}
	
	public void disconnect ()
	{
		if (device != null)
			device.close ();
	}

	public void send ()
	{		
		if (device != null && !string.IsNullOrEmpty (dataToSend.text)) {
			device.send (System.Text.Encoding.ASCII.GetBytes (dataToSend.text + (char)10));
		}
	}
	
	IEnumerator  ManageConnection (BluetoothDevice device)
	{
		//DataCanvas.SetActive(true);
		//InfoCanvas.SetActive(false);

		if (device.IsReading)
        {
			SceneManager.LoadScene(1);
		}

		
		
		while (device.IsReading)
		{

			byte[] msg = device.read();

			if (msg != null)
			{
				Debug.Log("KB");
				string content = System.Text.ASCIIEncoding.ASCII.GetString(msg);
				string[] lines = content.Split(new char[] { '\n', '\r' });

				int.TryParse(lines[0], out int answer);

				Jump.KBinput = answer;
				Light.KBinput = answer;
				Judge.KBinput = answer;
				Test.KBinput = answer;
				TapGetter.KBinput = answer;

				Debug.Log("KBinput: " + answer);
			}
			yield return null;
		}

	}

	void OnDestroy ()
	{
		BluetoothAdapter.OnDevicePicked -= HandleOnDevicePicked; 
		BluetoothAdapter.OnDeviceOFF -= HandleOnDeviceOff;
	}

}
