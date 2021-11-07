// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IMediaProtectionServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Allows a content enabler object to be exposed directly to an application rather than through a wrapper supplied by the ContentEnabler object.</summary>
  [Guid(2984119974, 8340, 18317, 135, 164, 139, 149, 32, 15, 133, 198)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaProtectionServiceRequest
  {
    /// <summary>Allows the application to identify the content protection system being used and therefore how to interpret the protection task.</summary>
    /// <returns>The vendor content protection system ID.</returns>
    Guid ProtectionSystem { get; }

    /// <summary>Retrieves the GUID for the type of operation that the IMediaProtectionServiceRequest performs.</summary>
    /// <returns>The GUID to retrieve.</returns>
    Guid Type { get; }
  }
}
