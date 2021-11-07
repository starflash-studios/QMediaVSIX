// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactChangeType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies the type of change that occurred for a ContactChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ContactChangeType
  {
    /// <summary>A contact was created.</summary>
    Created,
    /// <summary>A contact was modified.</summary>
    Modified,
    /// <summary>A contact was deleted.</summary>
    Deleted,
    /// <summary>Change tracking was lost. Call Reset to reestablish continuity with the ContactStore.</summary>
    ChangeTrackingLost,
  }
}
