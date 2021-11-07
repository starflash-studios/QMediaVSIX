// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.FindOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the options to use when doing a text search.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FindOptions : uint
  {
    /// <summary>Use the default text search options; namely, use case- independent, arbitrary character boundaries.</summary>
    None = 0,
    /// <summary>Match whole words.</summary>
    Word = 2,
    /// <summary>Match case; that is, a case-sensitive search.</summary>
    Case = 4,
  }
}
