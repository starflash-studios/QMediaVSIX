// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents the window on which to display the composition tree.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [Composable(typeof (ICompositionTargetFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  public class CompositionTarget : CompositionObject, ICompositionTarget
  {
    /// <summary>The root of the composition tree to display.</summary>
    /// <returns>The root of the composition tree to display.</returns>
    public extern Visual Root { [MethodImpl] get; [MethodImpl] set; }
  }
}
