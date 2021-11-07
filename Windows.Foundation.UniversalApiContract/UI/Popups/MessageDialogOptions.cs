// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.MessageDialogOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  /// <summary>Specifies less frequently used options for a MessageDialog.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum MessageDialogOptions : uint
  {
    /// <summary>No options are specified and default behavior is used.</summary>
    None = 0,
    /// <summary>Ignore user input for a short period. This enables browsers to defend against clickjacking.</summary>
    AcceptUserInputAfterDelay = 1,
  }
}
