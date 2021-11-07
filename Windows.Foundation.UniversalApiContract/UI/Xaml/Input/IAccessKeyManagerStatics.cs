// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IAccessKeyManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(1285615590, 55752, 20156, 180, 199, 48, 209, 131, 138, 129, 241)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AccessKeyManager))]
  internal interface IAccessKeyManagerStatics
  {
    bool IsDisplayModeEnabled { get; }

    event TypedEventHandler<object, object> IsDisplayModeEnabledChanged;

    void ExitDisplayMode();
  }
}
