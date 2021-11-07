// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.RenderedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides event data for the Rendered event.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class RenderedEventArgs : IRenderedEventArgs
  {
    /// <summary>Gets the duration of the time it took to render the most recent frame.</summary>
    /// <returns>The duration of the time it took to render the most recent frame.</returns>
    public extern TimeSpan FrameDuration { [MethodImpl] get; }
  }
}
