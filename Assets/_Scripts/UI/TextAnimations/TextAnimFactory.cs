using System.Collections.Generic;
using TMPro;

public static class TextAnimFactory
{
    private static Dictionary<TextAnim, ITextAnim> anims =
        new Dictionary<TextAnim, ITextAnim>
        {
            { TextAnim.Pop, new TextPopAnim() },
            { TextAnim.Fade, new TextFadeAnim() },
            { TextAnim.SlideUp, new TextSlideUpAnim() }
        };

    public static void Play(TextAnim anim, TMP_Text text)
    {
        anims[anim].Play(text);
    }
}
