// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IComponentConnector
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
  [Guid(4135127431, 59109, 18418, 146, 198, 236, 204, 228, 186, 21, 154)]
  public interface IComponentConnector
  {
    /// <summary>Attaches events and names to XAML-initiated content.</summary>
    /// <param name="connectionId">An identifier token to distinguish calls.</param>
    /// <param name="target">The target to connect events and names to.</param>
    void Connect(int connectionId, object target);
  }
}
