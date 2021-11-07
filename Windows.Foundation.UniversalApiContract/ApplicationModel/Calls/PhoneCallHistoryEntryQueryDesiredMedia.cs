// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryDesiredMedia
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  /// <summary>A filter used to retrieve call entries based on the contained media.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhoneCallHistoryEntryQueryDesiredMedia : uint
  {
    /// <summary>No associated media.</summary>
    None = 0,
    /// <summary>Audio media.</summary>
    Audio = 1,
    /// <summary>Video media.</summary>
    Video = 2,
    /// <summary>All media types.</summary>
    All = 4294967295, // 0xFFFFFFFF
  }
}
