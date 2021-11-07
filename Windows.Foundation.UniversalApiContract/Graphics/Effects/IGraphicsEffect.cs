// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Effects.IGraphicsEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Effects
{
  /// <summary>Base class for graphics effects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3411132622, 36838, 17974, 178, 2, 134, 31, 170, 7, 216, 243)]
  [WebHostHidden]
  public interface IGraphicsEffect : IGraphicsEffectSource
  {
    /// <summary>The name of the graphics effect.</summary>
    /// <returns>The name of the graphics effect.</returns>
    string Name { get; set; }
  }
}
