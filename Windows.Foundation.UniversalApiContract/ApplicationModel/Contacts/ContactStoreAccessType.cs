// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactStoreAccessType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Defines the type of access the app has to the ContactStore.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactStoreAccessType
  {
    /// <summary>Read and write contacts that belong to the app only.</summary>
    AppContactsReadWrite,
    /// <summary>Read access to all contacts, those provided by the calling app and from other sources. This value requires the contacts capability. See App capability declarations for more information.</summary>
    AllContactsReadOnly,
    /// <summary>Read and write access to all contacts. This value is not available to all apps. Your developer account must be specially provisioned by Microsoft in order to request this level of access.</summary>
    AllContactsReadWrite,
  }
}
