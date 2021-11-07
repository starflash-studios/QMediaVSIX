// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides data for the PartialMediaFailureDetected event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class PartialMediaFailureDetectedEventArgs : 
    IPartialMediaFailureDetectedEventArgs,
    IPartialMediaFailureDetectedEventArgs2
  {
    /// <summary>Initializes a new instance of the PartialMediaFailureDetectedEventArgs class.</summary>
    [MethodImpl]
    public extern PartialMediaFailureDetectedEventArgs();

    /// <summary>Gets a value indicating whether the stream that failed to decode contains audio or video.</summary>
    /// <returns>A value indicating whether the stream that failed to decode contains audio or video.</returns>
    public extern FailedMediaStreamKind StreamKind { [MethodImpl] get; }

    /// <summary>Gets error info for the media failure.</summary>
    /// <returns>The error info for the media failure.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
