// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines constants that specify the lookup behavior for references to application resources by Uniform Resource Identifier (URI) path.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ComponentResourceLocation
  {
    /// <summary>Lookup treats the APPXPACKAGE as the root.</summary>
    Application,
    /// <summary>Lookup expects that the resource is a nested resource of a component.</summary>
    Nested,
  }
}
