// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CharacterCasing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how a control modifies the case of characters as they are typed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  public enum CharacterCasing
  {
    /// <summary>The case of characters is left unchanged.</summary>
    Normal,
    /// <summary>Characters are changed to lowercase.</summary>
    Lower,
    /// <summary>Characters are changed to uppercase.</summary>
    Upper,
  }
}
