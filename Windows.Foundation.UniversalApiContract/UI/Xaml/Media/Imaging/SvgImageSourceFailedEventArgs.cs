// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.SvgImageSourceFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides event data for the SvgImageSource.OpenFailed event.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SvgImageSourceFailedEventArgs : ISvgImageSourceFailedEventArgs
  {
    /// <summary>Gets a value that indicates the reason for the SVG loading failure.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern SvgImageSourceLoadStatus Status { [MethodImpl] get; }
  }
}
