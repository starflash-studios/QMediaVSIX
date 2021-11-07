// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.CredentialSaveOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  /// <summary>Identifies the state of the dialog box option on whether to save credentials.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CredentialSaveOption
  {
    /// <summary>The "Save credentials?" dialog box is not selected, indicating that the user doesn't want their credentials saved.</summary>
    Unselected,
    /// <summary>The "Save credentials?" dialog box is selected, indicating that the user wants their credentials saved.</summary>
    Selected,
    /// <summary>The "Save credentials?" dialog box is not displayed at all.</summary>
    Hidden,
  }
}
