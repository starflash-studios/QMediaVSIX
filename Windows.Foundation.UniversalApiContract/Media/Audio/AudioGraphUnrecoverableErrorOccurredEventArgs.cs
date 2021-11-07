// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioGraphUnrecoverableErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents arguments for an UnrecoverableErrorOccurred event.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AudioGraphUnrecoverableErrorOccurredEventArgs : 
    IAudioGraphUnrecoverableErrorOccurredEventArgs
  {
    /// <summary>Gets the error associated with the event.</summary>
    /// <returns>An enumeration value indicating the error.</returns>
    public extern AudioGraphUnrecoverableError Error { [MethodImpl] get; }
  }
}
