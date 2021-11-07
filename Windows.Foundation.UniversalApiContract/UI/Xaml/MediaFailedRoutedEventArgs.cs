// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.MediaFailedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides event data for media failed events.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaFailedRoutedEventArgs : 
    ExceptionRoutedEventArgs,
    IMediaFailedRoutedEventArgs
  {
    /// <summary>Gets the trace information for a media failed event.</summary>
    /// <returns>The error trace for the failed media event.</returns>
    public extern string ErrorTrace { [MethodImpl] get; }
  }
}
