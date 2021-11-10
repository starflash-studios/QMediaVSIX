namespace System.Drawing.Icons.Native;

/// <inheritdoc cref="IconsExtractor"/>
internal struct Rect {
    internal int
        Left = 0,
        Top = 0,
        Right = 0,
        Bottom = 0;

    public Rect(int Left, int Top, int Right, int Bottom ) {
        this.Left = Left;
        this.Top = Top;
        this.Right = Right;
        this.Bottom = Bottom;
    }

    public static readonly Rect Zero = new Rect(0, 0, 0, 0);
}