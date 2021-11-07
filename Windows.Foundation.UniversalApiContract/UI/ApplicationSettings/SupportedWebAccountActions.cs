// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.SupportedWebAccountActions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Specifies actions that your app enables on an web account instance in the account settings pane.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SupportedWebAccountActions : uint
  {
    /// <summary>No action.</summary>
    None = 0,
    /// <summary>The app attempts to connect to the web account.</summary>
    Reconnect = 1,
    /// <summary>The app removes the web account from the account settings pane.</summary>
    Remove = 2,
    /// <summary>The app displays details about the web account.</summary>
    ViewDetails = 4,
    /// <summary>The app displays UI for managing the web account.</summary>
    Manage = 8,
    /// <summary>The app does a custom action with the web account.</summary>
    More = 16, // 0x00000010
  }
}
