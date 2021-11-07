// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.JumpListItemKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Specifies the kind of jump list item.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum JumpListItemKind
  {
    /// <summary>Indicates a jump list item that includes arguments.</summary>
    Arguments,
    /// <summary>Indicates a jump list item that is an inert separator within a custom jump list item group.</summary>
    Separator,
  }
}
