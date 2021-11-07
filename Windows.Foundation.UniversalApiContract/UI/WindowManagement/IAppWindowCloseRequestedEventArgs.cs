// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindowCloseRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(3925803482, 59298, 22440, 139, 94, 57, 196, 0, 58, 253, 187)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppWindowCloseRequestedEventArgs))]
  internal interface IAppWindowCloseRequestedEventArgs
  {
    bool Cancel { get; set; }

    Deferral GetDeferral();
  }
}
