// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatTransportInterpretedErrorCode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Specifies an interpretation for the error code.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ChatTransportInterpretedErrorCode
  {
    /// <summary>There was no error.</summary>
    None,
    /// <summary>There is no interpretation for the error code.</summary>
    Unknown,
    /// <summary>An invalid recipient address</summary>
    InvalidRecipientAddress,
    /// <summary>A network connectivity error</summary>
    NetworkConnectivity,
    /// <summary>A service denied error</summary>
    ServiceDenied,
    /// <summary>A timeout error</summary>
    Timeout,
  }
}
