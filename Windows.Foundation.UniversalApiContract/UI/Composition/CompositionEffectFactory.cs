// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionEffectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Creates a composition object that contains a Win2D effect description format in the Microsoft.Graphics.Canvas.Effects namespace.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [DualApiPartition(version = 167772164)]
  public sealed class CompositionEffectFactory : CompositionObject, ICompositionEffectFactory
  {
    /// <summary>Creates an instance of CompositionEffectBrush with the effect definition and animatable properties contained in the CompositionEffectFactory object.</summary>
    /// <returns>Returns the created CompositionEffectBrush object.</returns>
    [MethodImpl]
    public extern CompositionEffectBrush CreateBrush();

    /// <summary>An extended error code for the result of a call to CreateBrush.</summary>
    /// <returns>An extended error code for the result of a call to CreateBrush.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }

    /// <summary>The load status of a CreateBrush call.</summary>
    /// <returns>The load status of a CreateBrush call.</returns>
    public extern CompositionEffectFactoryLoadStatus LoadStatus { [MethodImpl] get; }
  }
}
