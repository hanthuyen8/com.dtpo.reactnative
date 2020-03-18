# Hướng dẫn cài đặt:
- Bước 1: Xóa hết các file script cũ của JavascriptFunction + Newtonsoft JSON trước đây.
- Bước 2: Mở Unity.
- Bước 3: Chọn Window > Package Manager

![Chọn Window > Package Manager](https://lh3.googleusercontent.com/7YO2ShqtmtqVCLHLX4qB9M2VcoIfccMOPZffYpX5M0tOmzCqCNV8ox15adEMY_A4XFS8Rre0-PSoM3eu9q1A95brh_vHB3O9_5vMGYRe1WA2BLLVC56StHumVQc73oe866_Yb0W1Kg=w2400)

- Bước 4: Chọn dấu cộng (+) > Add package from git url ...

![Chọn dấu cộng (+) > Add package from Git url](https://lh3.googleusercontent.com/fsbvfW0bnbzwWyPfba7H--xRAhMcHOcy7XR172Es-huubBjZWf-WEjobOUUEBKJDIQtC0KxtUbfxYA2iEspTbJQxzPPZedsq5bGoopklQkp3Y6cfTY0r72Vn3XJua8I9oCsl8IhXIw=w2400)
- Bước 5: Dán địa chỉ https://github.com/hanthuyen8/com.dtpo.reactnative.git vào textbox và nhấn Add

![Dán địa chỉ vào textbox và nhấn Add](https://lh3.googleusercontent.com/DaaWvZTbwIQFIA8bwVzZUT0suhOv2OXPtDM5hDboYJREQzTNgwkaZ9_vmxhKxH6Kxs-kUT00xNzb3vRnkQfKfKSUSBSKV471FDP7rOKtr2EIIXU-sbKej-6MUZA02c-wc4KXdZrjmw=w2400)

# Hướng dẫn sử dụng

*Lưu ý: Không cần tạo 1 GameObject trên Scene để sử dụng nữa. Các script bên trong package này sẽ tự xử lý.*

1. Để gửi tín hiệu ghi âm đến ReactNative, gọi Method:
```
ReactNative.RecordAudio(string keyWord, int second, Action<bool> onResult)
```
**Trong đó:** 
- **keyWord** là từ khóa cần so sánh với âm thanh thu được.
- **second** là số giây cần thu âm.
- **onResult** là một method cần truyền vào để nhận kết quả trả về, method phải nhận một tham số bool (true là kết quả kiểm tra ghi âm đã chính xác với keyWord và false là không chính xác).

**Ví dụ:** có thể viết một đoạn script như sau để sử dụng
```
public void SendRecord()
{
    ReactNative.RecordAudio("sister", 3, AudioResult);
}

private void AudioResult(bool result)
{
    if (result == true)
    {
        // Player đã phát âm đúng.
        // Làm gì sau đó thì tùy.
    }
    else
    {
        // Player đã phát âm sai.
        // Làm gì sau đó thì tùy.
    }
}
```
2. Để gửi điểm số đến React Native, gọi một trong ba Method sau:
```
ReactNative.SendScore(SendScoreData scoreData)
ReactNative.SendScore(SendScoreData[] scoreData)
ReactNative.SendScore(List<SendScoreData> scoreData)
```
3. Để thoát ra khỏi Unity (thoát game), gọi Method sau:
```
ReactNative.SendExitCommand()
```