// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.RevealBorderBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Paints a control border with a reveal effect using composition brush and light effects.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IRevealBorderBrushFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public class RevealBorderBrush : RevealBrush, IRevealBorderBrush
  {
    /// <summary>Initializes a new instance of the RevealBorderBrush class.</summary>
    [MethodImpl]
    public extern RevealBorderBrush();
  }
}
