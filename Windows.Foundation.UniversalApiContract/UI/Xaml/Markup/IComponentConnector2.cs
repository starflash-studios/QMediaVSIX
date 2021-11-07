// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IComponentConnector2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides infrastructure support for event wiring and build actions.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3700373131, 60620, 18830, 177, 57, 145, 20, 34, 84, 215, 174)]
  public interface IComponentConnector2
  {
    /// <summary>Returns the IComponentConnector for this connection.</summary>
    /// <param name="connectionId">An identifier token to distinguish calls.</param>
    /// <param name="target">The target to connect events and names to.</param>
    /// <returns>The IComponentConnector for this connection.</returns>
    IComponentConnector GetBindingConnector(int connectionId, object target);
  }
}
