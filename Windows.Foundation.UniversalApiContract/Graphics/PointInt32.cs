// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.PointInt32
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics
{
  /// <summary>Defines a point in a two-dimensional plane.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public struct PointInt32
  {
    /// <summary>The X coordinate value of a point.</summary>
    public int X;
    /// <summary>The Y coordinate value of a point.</summary>
    public int Y;
  }
}
