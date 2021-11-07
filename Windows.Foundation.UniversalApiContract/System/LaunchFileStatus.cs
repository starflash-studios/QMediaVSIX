// Decompiled with JetBrains decompiler
// Type: Windows.System.LaunchFileStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Specifies the result of activating an application for a file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum LaunchFileStatus
  {
    /// <summary>The application activated successfully.</summary>
    Success,
    /// <summary>The application cannot be activated which may be because it is being updated by the store, it was installed on a removable device that is not available, and so on.</summary>
    AppUnavailable,
    /// <summary>The application cannot be activated for this file because files may not cross user boundaries.</summary>
    DeniedByPolicy,
    /// <summary>The application you are trying to activate does not support this file type.</summary>
    FileTypeNotSupported,
    /// <summary>An unknown error was encountered while activating the application.</summary>
    Unknown,
  }
}
