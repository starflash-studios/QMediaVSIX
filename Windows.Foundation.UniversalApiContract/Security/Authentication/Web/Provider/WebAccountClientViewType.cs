// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountClientViewType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents the levels of information about a web account shown to the client.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebAccountClientViewType
  {
    /// <summary>Shows only the Id.</summary>
    IdOnly,
    /// <summary>Shows the Id and properties.</summary>
    IdAndProperties,
  }
}
