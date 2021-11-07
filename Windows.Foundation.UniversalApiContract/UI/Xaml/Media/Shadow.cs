// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Shadow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>The base class for shadow effects that can be applied to a XAML element.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IShadowFactory), CompositionType.Public, 524288, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class Shadow : DependencyObject, IShadow
  {
  }
}
