using UnityEngine;
using System.IO;

[System.Serializable]
public class BlockData
{
    public Block[] blocks;
}

[System.Serializable]
public class Block
{
    public KeyCode key;
    public int position;
}

public class JsonReader : MonoBehaviour
{
    public string jsonFilePath = "Test.json"; // JSON 文件的路徑

    private void Start()
    {
        // 讀取 JSON 文件
        string jsonString = File.ReadAllText(jsonFilePath);

        // 解析 JSON 字符串為 BlockData 對象
        BlockData data = JsonUtility.FromJson<BlockData>(jsonString);

    
        foreach (Block block in data.blocks)
        {
            Debug.Log("Position: " + block.position + ", Key: " + block.key.ToString());
            // 解析JSON檔
        }
    }
}
