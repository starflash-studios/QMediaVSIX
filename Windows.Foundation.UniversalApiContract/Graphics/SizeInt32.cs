// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.SizeInt32
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics
{
  /// <summary>Defines the height and wide of a surface in a two-dimensional plane.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public struct SizeInt32
  {
    /// <summary>The width of a surface.</summary>
    public int Width;
    /// <summary>The height of a surface.</summary>
    public int Height;
  }
}
