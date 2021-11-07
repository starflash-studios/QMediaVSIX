// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.CompositionType
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

namespace Windows.Foundation.Metadata
{
  /// <summary>Specifies the visibility of a programming element for which the composable attribute is applied.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum CompositionType
  {
    /// <summary>Indicates that access to the programming element is limited to other elements in the containing class or types derived from the containing class.</summary>
    Protected = 1,
    /// <summary>Indicates that access to the programming element is not restricted.</summary>
    Public = 2,
  }
}
