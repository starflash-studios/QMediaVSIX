// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextTextUpdatingResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Defines constants that specify the result of handling the TextUpdating event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CoreTextTextUpdatingResult
  {
    /// <summary>The text update operation completed successfully.</summary>
    Succeeded,
    /// <summary>The text update operation was not completed as the text input server expected. The state of the text input control is unchanged.</summary>
    Failed,
  }
}
