// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the ViewChanged event and similar control-specific events.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class ScrollViewerViewChangedEventArgs : IScrollViewerViewChangedEventArgs
  {
    /// <summary>Initializes a new instance of the ScrollViewerViewChangedEventArgs class.</summary>
    [MethodImpl]
    public extern ScrollViewerViewChangedEventArgs();

    /// <summary>Gets a value that indicates whether the underlying manipulation that raised the event is complete.</summary>
    /// <returns>**True** if the manipulation is at an intermediate stage and not yet final; **false** if the manipulation is final.</returns>
    public extern bool IsIntermediate { [MethodImpl] get; }
  }
}
