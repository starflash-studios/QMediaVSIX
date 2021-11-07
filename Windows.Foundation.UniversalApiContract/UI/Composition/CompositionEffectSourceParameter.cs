// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionEffectSourceParameter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition
{
  /// <summary>Used to declare an arbitrary name (a String) to be associated with a CompositionBrush (the “effect source”). The association of the given name and the effect source occurs when the SetSourceParameter method of a CompositionEffectBrush is called.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ICompositionEffectSourceParameterFactory), 131072, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  public sealed class CompositionEffectSourceParameter : 
    ICompositionEffectSourceParameter,
    IGraphicsEffectSource
  {
    /// <summary>Creates an instance of CompositionEffectSourceParameter.</summary>
    /// <param name="name">The name for the CompositionEffectSourceParameter instance.</param>
    [MethodImpl]
    public extern CompositionEffectSourceParameter(string name);

    /// <summary>The name associated with the effect source.</summary>
    /// <returns>The name associated with the effect source.</returns>
    public extern string Name { [MethodImpl] get; }
  }
}
