// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines the navigation action for navigation hosts and navigation initiators.</summary>
  [WebHostHidden]
  [Guid(3206649257, 62698, 17206, 151, 124, 248, 252, 247, 139, 13, 158)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INavigate
  {
    bool Navigate(TypeName sourcePageType);
  }
}
