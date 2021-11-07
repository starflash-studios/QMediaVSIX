// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.WebAccountAction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Specifies actions that your app does on an web account.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebAccountAction
  {
    /// <summary>The app attempts to connect to the web account.</summary>
    Reconnect,
    /// <summary>The app removes the web account from the account settings pane.</summary>
    Remove,
    /// <summary>The app displays details about the web account.</summary>
    ViewDetails,
    /// <summary>The app displays UI for managing the web account.</summary>
    Manage,
    /// <summary>The app does a custom action with the web account.</summary>
    More,
  }
}
