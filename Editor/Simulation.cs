using UnityEditor;

public static class Simulation
{
    [MenuItem("ReactNative/Giả lập/Cho kết quả ghi âm là đúng")]
    public static void Simulate_ResultAudio_True()
    {
        ReactNative.Instance.ResultAudio("true");
    }

    [MenuItem("ReactNative/Giả lập/Cho kết quả ghi âm là sai")]
    public static void Simulate_ResultAudio_False()
    {
        ReactNative.Instance.ResultAudio("false");
    }
}