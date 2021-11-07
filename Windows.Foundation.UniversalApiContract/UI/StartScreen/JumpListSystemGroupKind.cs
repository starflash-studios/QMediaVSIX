// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.JumpListSystemGroupKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Indicates the kind of system group used by an app's jump list.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum JumpListSystemGroupKind
  {
    /// <summary>Specifies that no system managed group be used in the jump list.</summary>
    None,
    /// <summary>Specifies that the system managed frequent group be used in the jump list.</summary>
    Frequent,
    /// <summary>Specifies that the system managed recent group be used in the jump list.</summary>
    Recent,
  }
}
