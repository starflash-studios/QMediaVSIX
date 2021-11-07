// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.AmbientLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A light that illuminates every targeted Visual equally.</summary>
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class AmbientLight : CompositionLight, IAmbientLight, IAmbientLight2
  {
    /// <summary>Color of the light. Animatable.</summary>
    /// <returns>The color of the ambient light.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the intensity of the light.</summary>
    /// <returns>The intensity of the light.</returns>
    public extern float Intensity { [MethodImpl] get; [MethodImpl] set; }
  }
}
