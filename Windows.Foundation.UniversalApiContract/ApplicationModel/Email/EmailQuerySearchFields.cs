// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailQuerySearchFields
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the field(s) by which to search a collection of email messages. Use the OR operator to combine these values together into a single bit field.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum EmailQuerySearchFields : uint
  {
    /// <summary>No search field defined.</summary>
    None = 0,
    /// <summary>Search by subject field.</summary>
    Subject = 1,
    /// <summary>Search by sender field.</summary>
    Sender = 2,
    /// <summary>Search by preview text field.</summary>
    Preview = 4,
    /// <summary>Search by members of the recipient list.</summary>
    Recipients = 8,
    /// <summary>Search by all searchable fields.</summary>
    All = 4294967295, // 0xFFFFFFFF
  }
}
