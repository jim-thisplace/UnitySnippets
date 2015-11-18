// Fader

public Texture FadeBlackTexture;
public Texture FadeWhiteTexture;
float GUIAlpha = 0.0f;
bool fadingToBlack = false;
public float fadeSpeed = 0.5f;


void OnGUI(){
    Color color = new Color (0, 0, 0);

    if (fadingToBlack) {
        if(GUIAlpha < 1) {
        GUIAlpha += fadeSpeed * Time.deltaTime;
        GUIAlpha = Mathf.Clamp01(GUIAlpha);
        color.a = GUIAlpha;
        }

        GUI.color = color;
        GUI.depth = -1000;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), FadeBlackTexture);
    }
}