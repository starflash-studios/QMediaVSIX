// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.FormatEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Defines values that indicate the state of a character or paragraph formatting property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FormatEffect
  {
    /// <summary>Turns off the property.</summary>
    Off,
    /// <summary>Turns on the property.</summary>
    On,
    /// <summary>Toggles the current setting.</summary>
    Toggle,
    /// <summary>No change.</summary>
    Undefined,
  }
}
