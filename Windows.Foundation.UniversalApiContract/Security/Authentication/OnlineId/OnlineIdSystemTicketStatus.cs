// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdSystemTicketStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Represents the status of a call to retrieve the system ticket.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum OnlineIdSystemTicketStatus
  {
    /// <summary>The call to retrieve the system ticket was successful.</summary>
    Success,
    /// <summary>An unexpected error prevented the retrieval of the system ticket.</summary>
    Error,
    /// <summary>A network error prevented the retrieval of the system ticket.</summary>
    ServiceConnectionError,
  }
}
