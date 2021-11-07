// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectionProfileDeleteStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Defines values that indicate the result of an attempt to delete a connection profile.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum ConnectionProfileDeleteStatus
  {
    /// <summary>The deletion succeeded.</summary>
    Success,
    /// <summary>The deletion failed because it was denied by the user, through the user interface (UI).</summary>
    DeniedByUser,
    /// <summary>The deletion failed because it was denied by the system.</summary>
    DeniedBySystem,
    /// <summary>The deletion failed due to an unknown error.</summary>
    UnknownError,
  }
}
