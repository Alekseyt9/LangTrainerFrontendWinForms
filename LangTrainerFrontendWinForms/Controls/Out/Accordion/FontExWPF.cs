
using System.Collections;

namespace Opulos.Core.UI {

public static partial class FontEx {


	///<summary>
	///This method is the first step in creating a image from a Font and some text. The inputs are parallel arrays in order of preference.
	///The first font that can be created and supports a glyph for each character in the text are in the 'out' variables.
	///</summary>
	public static void CreateFont(String[] fontNames, float[] fontSizes, FontStyle[] fontStyles, String[] texts, out Font font, out String text, int startIndex = 0) {
		FontGlyph fg = CreateFont(fontNames, texts, fontSizes, fontStyles, startIndex);
		font = fg.Font;
		text = fg.Text;
	}

	private static readonly Hashtable htUnsupportedFontNames = new Hashtable(StringComparer.OrdinalIgnoreCase);
	public static FontGlyph CreateFont(String[] fontNames, String[] texts, float[] fontSizes, FontStyle[] fontStyles, int startIndex = 0) {
		Font font = null;
		String fontName = "";
		String fontText = "";
		float fontSize = 10f;
		FontStyle fontStyle = FontStyle.Regular;
		int max = Math.Max(fontNames.Length, texts.Length);

		for (int i = startIndex; i < max; i++) {
			if (i < fontNames.Length)
				fontName = fontNames[i];
			if (i < texts.Length)
				fontText = texts[i];
			if (fontSizes != null && i < fontSizes.Length)
				fontSize = fontSizes[i];
			if (fontStyles != null && i < fontStyles.Length)
				fontStyle = fontStyles[i];

			try {
				if (!htUnsupportedFontNames.ContainsKey(fontName)) {
					Font f = FontEx.New(fontName, fontSize, fontStyle);
                    font = f;
                    break;
					/*if (f.HasGlyphs(fontText)) {
						font = f;
						break;
					}*/
				}
			} catch {
				htUnsupportedFontNames[fontName] = "";
			}
		}
		return new FontGlyph(font, fontText);
	}
}

public class FontGlyph {
	public readonly String Text;
	public readonly Font Font;

	public FontGlyph(Font font, String text) {
		this.Font = font;
		this.Text = text;
	}

	public override String ToString() {
		return Text;
	}
}
}