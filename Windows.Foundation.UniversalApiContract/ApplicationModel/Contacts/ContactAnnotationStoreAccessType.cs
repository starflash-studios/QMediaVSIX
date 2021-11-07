// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAnnotationStoreAccessType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies if the app can read and write all annotations or only those belonging to the app itself.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactAnnotationStoreAccessType
  {
    /// <summary>Only local app contact annotations.</summary>
    AppAnnotationsReadWrite,
    /// <summary>All contact annotations.</summary>
    AllAnnotationsReadWrite,
  }
}
