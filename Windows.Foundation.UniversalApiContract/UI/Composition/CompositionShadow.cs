// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionShadow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Base class for shadows that can be applied to a SpriteVisual.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772164)]
  [Composable(typeof (ICompositionShadowFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  public class CompositionShadow : CompositionObject, ICompositionShadow
  {
  }
}
