// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextSelectionUpdatingResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Defines constants that specify the result of handling the SelectionUpdating event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CoreTextSelectionUpdatingResult
  {
    /// <summary>The selection update operation completed successfully.</summary>
    Succeeded,
    /// <summary>The selection update operation was not completed as the text input server expected.</summary>
    Failed,
  }
}
