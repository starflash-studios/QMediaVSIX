// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IContactPanelActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated by the contact panel.</summary>
  [Guid(1388012516, 54228, 19299, 128, 81, 74, 242, 8, 44, 171, 128)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public interface IContactPanelActivatedEventArgs
  {
    /// <summary>Gets the contact panel.</summary>
    /// <returns>The contact panel.</returns>
    ContactPanel ContactPanel { get; }

    /// <summary>Gets the contact.</summary>
    /// <returns>The contact.</returns>
    Contact Contact { get; }
  }
}
