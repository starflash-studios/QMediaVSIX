// Decompiled with JetBrains decompiler
// Type: Windows.Storage.KnownFoldersAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>
  /// </summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum KnownFoldersAccessStatus
  {
    /// <summary>
    /// </summary>
    DeniedBySystem,
    /// <summary>
    /// </summary>
    NotDeclaredByApp,
    /// <summary>
    /// </summary>
    DeniedByUser,
    /// <summary>
    /// </summary>
    UserPromptRequired,
    /// <summary>
    /// </summary>
    Allowed,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] AllowedPerAppFolder,
  }
}
