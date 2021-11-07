// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IFrameworkViewSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Defines a factory for view provider objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3447129620, 26052, 17004, 148, 148, 52, 252, 67, 85, 72, 98)]
  [WebHostHidden]
  public interface IFrameworkViewSource
  {
    /// <summary>Returns a view provider object.</summary>
    /// <returns>An object that implements a view provider.</returns>
    IFrameworkView CreateView();
  }
}
