// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IObjectModelProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Provides access to the underlying object model implemented by a control or app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3284809401, 1939, 20176, 187, 244, 159, 244, 224, 249, 143, 128)]
  public interface IObjectModelProvider
  {
    /// <summary>Returns an interface used to access the underlying object model of the provider.</summary>
    /// <returns>An untyped interface for accessing the underlying object model.</returns>
    object GetUnderlyingObjectModel();
  }
}
