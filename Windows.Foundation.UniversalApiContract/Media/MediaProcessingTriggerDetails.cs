// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProcessingTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides a media processing background task access to the set of arguments supplied in the call to MediaProcessingTrigger.RequestAsync.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaProcessingTriggerDetails : IMediaProcessingTriggerDetails
  {
    /// <summary>Gets a value set containing the arguments supplied in the call to MediaProcessingTrigger.RequestAsync.</summary>
    /// <returns>A value set containing the arguments supplied in the call to MediaProcessingTrigger.RequestAsync.</returns>
    public extern ValueSet Arguments { [MethodImpl] get; }
  }
}
