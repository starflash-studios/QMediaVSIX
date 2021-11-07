// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactQuerySearchFields
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Defines which contact fields to search for a text match.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum ContactQuerySearchFields : uint
  {
    /// <summary>None</summary>
    None = 0,
    /// <summary>Name</summary>
    Name = 1,
    /// <summary>Email address</summary>
    Email = 2,
    /// <summary>Phone number</summary>
    Phone = 4,
    /// <summary>All</summary>
    All = 4294967295, // 0xFFFFFFFF
  }
}
