// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IInitializeWithCoreWindow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines the initialization behavior for apps that use CoreWindow.</summary>
  [Guid(412033238, 39027, 17994, 172, 229, 87, 224, 16, 244, 101, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IInitializeWithCoreWindow
  {
    /// <summary>Specifies the method that provides the initial CoreWindow instance for an app.</summary>
    /// <param name="window">The new app window.</param>
    void Initialize(CoreWindow window);
  }
}
