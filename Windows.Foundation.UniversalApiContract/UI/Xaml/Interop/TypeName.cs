// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.TypeName
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Substitutes for **System.Type** such that type information reported by other APIs doesn't have a dependency on the common language runtime (CLR). This structure is used as a value by properties such as UnderlyingType and Type.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct TypeName
  {
    /// <summary>The name of the type. Depending on the value of *Kind* (see below), *Name* can contain any of the following.</summary>
    public string Name;
    /// <summary>A TypeKind value containing basic guidance regarding the origin of the type.</summary>
    public TypeKind Kind;
  }
}
