// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.RectInt32
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics
{
  /// <summary>Defines the size and location of a rectangular surface.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public struct RectInt32
  {
    /// <summary>The X coordinate at the center of a rectangle.</summary>
    public int X;
    /// <summary>The Y coordinate at the center of a rectangle.</summary>
    public int Y;
    /// <summary>The width of a rectangle.</summary>
    public int Width;
    /// <summary>The height of a rectangle.</summary>
    public int Height;
  }
}
