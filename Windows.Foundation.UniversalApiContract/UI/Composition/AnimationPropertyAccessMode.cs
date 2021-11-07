// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.AnimationPropertyAccessMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Defines constants that specify how an animated property can be accessed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  public enum AnimationPropertyAccessMode
  {
    /// <summary>The property cannot be accessed.</summary>
    None,
    /// <summary>The property can only be read.</summary>
    ReadOnly,
    /// <summary>The property can only be written to.</summary>
    WriteOnly,
    /// <summary>The property can be read or written to.</summary>
    ReadWrite,
  }
}
