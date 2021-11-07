// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Represents a background transfer operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3738200134, 37066, 17659, 143, 177, 18, 65, 84, 192, 213, 57)]
  public interface IBackgroundTransferOperation
  {
    /// <summary>Gets the Guid for the background transfer operation.</summary>
    /// <returns>The unique ID for the background transfer operation.</returns>
    Guid Guid { get; }

    /// <summary>Gets the URI for the background transfer.</summary>
    /// <returns>The URI.</returns>
    global::Windows.Foundation.Uri RequestedUri { get; }

    /// <summary>Specifies the method to use for the background transfer operation.</summary>
    /// <returns>The method to use. This value can be **GET**, **PUT**, **RETR**, or **STOR**.</returns>
    string Method { get; }

    /// <summary>Gets a string value indicating the group the transfer belongs to.</summary>
    /// <returns>The group name.</returns>
    string Group { [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets and sets the cost policy for the background transfer.</summary>
    /// <returns>Specifies whether the transfer can happen over costed networks.</returns>
    BackgroundTransferCostPolicy CostPolicy { get; set; }

    /// <summary>Gets the partial response at the specified position.</summary>
    /// <param name="position">The position at which to start reading.</param>
    /// <returns>The result stream.</returns>
    IInputStream GetResultStreamAt(ulong position);

    /// <summary>Gets the response infomation.</summary>
    /// <returns>Contains the data returned by a server response.</returns>
    ResponseInformation GetResponseInformation();
  }
}
