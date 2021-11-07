// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MseEndOfStreamStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the status at the end of stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MseEndOfStreamStatus
  {
    /// <summary>End of stream was successful.</summary>
    Success,
    /// <summary>End of stream had a network error.</summary>
    NetworkError,
    /// <summary>End of stream had a decode error.</summary>
    DecodeError,
    /// <summary>End of stream had an unknown error.</summary>
    UnknownError,
  }
}
