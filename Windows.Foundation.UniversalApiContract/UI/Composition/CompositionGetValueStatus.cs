// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionGetValueStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Indicates the outcome of an attempt to retrieve the value of a key-value pair.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public enum CompositionGetValueStatus
  {
    /// <summary>The value successfully retrieved.</summary>
    Succeeded,
    /// <summary>The value type of the key-value pair is different than the value type requested.</summary>
    TypeMismatch,
    /// <summary>The key-value pair does not exist.</summary>
    NotFound,
  }
}
