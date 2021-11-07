// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderTokenObjects2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Defines properties for web account provider token objects that are retrieved in the context of a specific user.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(270579859, 23717, 20479, 149, 251, 184, 32, 39, 63, 195, 149)]
  public interface IWebAccountProviderTokenObjects2 : IWebAccountProviderTokenObjects
  {
    /// <summary>Gets the user for this token objects set.</summary>
    /// <returns>The user for this token objects set.</returns>
    User User { get; }
  }
}
