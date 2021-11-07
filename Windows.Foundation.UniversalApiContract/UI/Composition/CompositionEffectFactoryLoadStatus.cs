// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionEffectFactoryLoadStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>The status of the asynchronous compilation of a shader for an effect description.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum CompositionEffectFactoryLoadStatus
  {
    /// <summary>Other error.</summary>
    Other = -1, // 0xFFFFFFFF
    /// <summary>The operation was successful.</summary>
    Success = 0,
    /// <summary>The effect was too complex.</summary>
    EffectTooComplex = 1,
    /// <summary>The operation is still pending.</summary>
    Pending = 2,
  }
}
