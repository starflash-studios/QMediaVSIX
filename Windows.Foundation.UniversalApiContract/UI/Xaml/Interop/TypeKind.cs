// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.TypeKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Provides basic guidance about the origin of a type. Used as a value by TypeName.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TypeKind
  {
    /// <summary>The type is a language-level primitive.</summary>
    Primitive,
    /// <summary>The type is declared through WinMD (Windows Runtime metadata).</summary>
    Metadata,
    /// <summary>The type is a custom type declared by means other than WinMD.</summary>
    Custom,
  }
}
